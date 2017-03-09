using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Windows.Forms;

using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace isthatAlive {
    public partial class AppMain : Form {

        private bool neverVisibleBallon = false;

        private bool collectOK = false;
        private bool collectStatus = false;

        private string statusText = "Idle";

        private DateTime dul;
        private DateTime now;
        private TimeSpan ts;

        public AppMain() {
            InitializeComponent();
        }

        private void toggle(ref bool flag) {
            flag = (flag == true ? false : true);
        }

        private void setTooltip(string str) {
            statusLabel.Text = str;
        }

        private void startOrStopButton_MouseHover(object sender, EventArgs e) {
            if (this.collectStatus == false) {
                statusLabel.Text = "상태 수집을 시작합니다.";
            } else {
                statusLabel.Text = "상태 수집을 중단합니다.";
            }
        }

        private void startOrStopButton_MouseLeave (object sender, EventArgs e) {
            setTooltip(this.statusText);
        }

        private void saveButton_MouseHover (object sender, EventArgs e) {
            statusLabel.Text = "수집한 결과를 엑셀 파일로 내보냅니다.";
        }

        private void aboutButton_MouseHover (object sender, EventArgs e) {
            statusLabel.Text = "프로그램의 정보를 봅니다.";
        }

        private void AppMain_Load (object sender, EventArgs e) {
            textURL.Focus();
            textURL.ImeMode = ImeMode.Off;
        }

        private void startOrStopButton_Click (object sender, EventArgs e) {
            if (this.collectStatus == false) {

                if (textURL.Text.Equals(null) || textURL.Text.Equals("")) {
                    MessageBox.Show("URL을 입력해주세요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textURL.Focus();

                } else if (this.collectOK == false) {
                    MessageBox.Show("사이트 유효성을 검사해주시기 바랍니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                } else {
                    BeforeStartWarning bsw = new BeforeStartWarning();
                    DialogResult dr = bsw.ShowDialog();

                    if (dr == DialogResult.Yes) {
                        startOrStopButton.Text = "중지";
                        startOrStopButton.Image = Properties.Resources.StatusStop_16x;

                        this.statusText = "수집이 시작되었습니다";
                        setTooltip(this.statusText);

                        textURL.Enabled = false;
                        btnValidate.Enabled = false;
                        numericUpDown1.Enabled = false;

                        
                        radioButton1.Enabled = false;
                        radioButton2.Enabled = false;
                        radioButton3.Enabled = false;
                        radioButton4.Enabled = false;
                        radioButton5.Enabled = false;
                        radioButton6.Enabled = false;
                        

                        this.now = DateTime.Now;

                        if (radioButton1.Checked == true) {
                            ts = new TimeSpan(0, 15, 0);
                        } else if (radioButton2.Checked == true) {
                            ts = new TimeSpan(0, 30, 0);
                        } else if (radioButton3.Checked == true) {
                            ts = new TimeSpan(1, 0, 0);
                        } else if (radioButton4.Checked == true) {
                            ts = new TimeSpan(6, 0, 0);
                        } else if (radioButton5.Checked == true) {
                            ts = new TimeSpan(12, 0, 0);
                        } else if (radioButton6.Checked == true) {
                            ts = new TimeSpan(24, 0, 0);
                        }
                        this.dul = this.now.Add(ts);

                        collectTimer.Interval = Convert.ToInt32((numericUpDown1.Value * 1000) * 60);
                        collectTimer.Enabled = true;
                        //https://dmcr.ajou.ac.kr


                        toggle(ref collectStatus);
                    }
                }

            } else {
                startOrStopButton.Text = "시작";
                startOrStopButton.Image = Properties.Resources.Run_16x;

                this.statusText = "Idle";
                setTooltip(this.statusText);

                textURL.Enabled = true;
                btnValidate.Enabled = true;
                numericUpDown1.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                radioButton5.Enabled = true;
                radioButton6.Enabled = true;

                collectTimer.Enabled = false;

                if (collectGrid.Rows.Count > 0) saveButton.Enabled = true;

                toggle(ref collectStatus);
            }
        }

        private void aboutButton_Click (object sender, EventArgs e) {
            AboutThisProgram atp = new AboutThisProgram();
            atp.ShowDialog();
        }

        private void btnValidate_Click (object sender, EventArgs e) {
            if (textURL.Text.Equals(null) || textURL.Text.Equals("")) {
                MessageBox.Show("URL을 입력해주세요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textURL.Focus();
            } else {
                try {
                    HttpWebRequest hwr = (HttpWebRequest) WebRequest.Create(textURL.Text);
                    hwr.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.7 (KHTML, like Gecko) Chrome/7.0.517.44 Safari/534.7 IsThatAliveUsing";
                    HttpWebResponse res = (HttpWebResponse) hwr.GetResponse();

                    HttpStatusCode hsc = res.StatusCode;

                    if (hsc == HttpStatusCode.Accepted || hsc == HttpStatusCode.Ambiguous || hsc == HttpStatusCode.Continue || hsc == HttpStatusCode.Created || hsc == HttpStatusCode.OK) {
                        MessageBox.Show("사용할 수 있는 웹 사이트입니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.collectOK = true;
                    } else {
                        throw new Exception();
                    }
                } catch (Exception ee) {
                    MessageBox.Show("사용할 수 없는 웹 사이트입니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.collectOK = false;
                }

            }

        }

        private void collectTimer_Tick (object sender, EventArgs e) {
            if (DateTime.Now.Ticks < this.dul.Ticks) {
                try {
                    
                    HttpWebRequest hwr = (HttpWebRequest) WebRequest.Create(textURL.Text);
                    hwr.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.7 (KHTML, like Gecko) Chrome/7.0.517.44 Safari/534.7 IsThatAliveUsing";
                    HttpWebResponse res = (HttpWebResponse) hwr.GetResponse();
                    
                    collectGrid.Rows.Add(new string [] { DateTime.Now.ToString(), String.Format("{0}", (int) res.StatusCode), res.StatusDescription });

                } catch (Exception ee) {
                    collectGrid.Rows.Add(new string [] { DateTime.Now.ToString(), "000", String.Format("Failed: {0}", ee.Message) });

                }

                
            } else {
                if(this.Visible == false) {
                    appNotifyIcon_DoubleClick(sender, e);
                }
                MessageBox.Show("수집이 모두 끝났습니다", "완료", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                startOrStopButton_Click(sender, e);
            }
            
        }

        private void saveButton_Click (object sender, EventArgs e) {
            this.saveDialog.FileName = String.Format("isthataliveresult_{0}",DateTime.Now.Ticks.ToString());
            this.saveDialog.DefaultExt = "xls";
            this.saveDialog.Filter = "Excel files (*.xls)|*.xls";
            this.saveDialog.InitialDirectory = "c:\\";

            DialogResult result = saveDialog.ShowDialog();

            if (result == DialogResult.OK) {
                statusLabel.Text = "저장중입니다. 잠시만 기다려 주세요.";

                int num = 0;
                object missingType = Type.Missing;

                Excel.Application objApp;
                Excel._Workbook objBook;
                Excel.Workbooks objBooks;
                Excel.Sheets objSheets;
                Excel._Worksheet objSheet;
                Excel.Range range;

                string [] headers = new string [collectGrid.ColumnCount];
                string [] columns = new string [collectGrid.ColumnCount];

                for (int c = 0; c < collectGrid.ColumnCount; c++) {
                    headers [c] = collectGrid.Rows [0].Cells [c].OwningColumn.HeaderText.ToString();
                    num = c + 65;
                    columns [c] = Convert.ToString((char) num);
                }

                try {
                    objApp = new Excel.Application();
                    objBooks = objApp.Workbooks;
                    objBook = objBooks.Add(Missing.Value);
                    objSheets = objBook.Worksheets;
                    objSheet = (Excel._Worksheet) objSheets.get_Item(1);

                    for (int c = 0; c < collectGrid.ColumnCount; c++) {
                        range = objSheet.get_Range(columns [c] + "1", Missing.Value);
                        range.set_Value(Missing.Value, headers [c]);
                    }

                    for (int i = 0; i < collectGrid.RowCount; i++) {
                        for (int j = 0; j < collectGrid.ColumnCount; j++) {
                            range = objSheet.get_Range(columns [j] + Convert.ToString(i + 2), Missing.Value);
                            if (collectGrid.Rows [i].Cells [j].Value != null) {
                                range.set_Value(Missing.Value, collectGrid.Rows [i].Cells [j].Value.ToString());
                            }
                        }
                    }

                    objApp.Visible = false;
                    objApp.UserControl = false;

                    objBook.SaveAs(saveDialog.FileName,
                              Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal,
                              missingType, missingType, missingType, missingType,
                              Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                              missingType, missingType, missingType, missingType, missingType);

                    objBook.Close(false, missingType, missingType);

                    Cursor.Current = Cursors.Default;

                    MessageBox.Show("저장을 완료했습니다", "저장 끝!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    setTooltip(this.statusText);

                } catch (Exception theException) {
                    String errorMessage;
                    errorMessage = "Error: ";
                    errorMessage = String.Concat(errorMessage, theException.Message);
                    errorMessage = String.Concat(errorMessage, theException.Source);

                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    setTooltip(this.statusText);
                }
            }
        }

        private void AppMain_FormClosing (object sender, FormClosingEventArgs e) {
            if (this.collectStatus == true) {
                e.Cancel = true;
                this.Visible = false;

                appNotifyIcon.Visible = true;

                if (neverVisibleBallon == false) {
                    appNotifyIcon.BalloonTipTitle = "Is that Alive: 상태 수집 작동 중";
                    appNotifyIcon.BalloonTipText = "프로그램이 대상 사이트의 상태를 계속 수집하고 있습니다.";
                    appNotifyIcon.BalloonTipIcon = ToolTipIcon.Info;

                    appNotifyIcon.ShowBalloonTip(1000);

                    neverVisibleBallon = true;
                }
            }
        }

        private void appNotifyIcon_DoubleClick (object sender, EventArgs e) {
            this.Visible = true;
            if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;
            appNotifyIcon.Visible = false;
            this.Activate();
        }

        private void 종료QToolStripMenuItem_Click (object sender, EventArgs e) {
            appNotifyIcon_DoubleClick(sender, e);

            DialogResult r = MessageBox.Show("정말로 종료하시겠습니까? 저장되지 않은 사항은 모두 유실됩니다.", "종료 알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(r == DialogResult.Yes) {
                // abort task
                startOrStopButton_Click(sender, e);

                Application.Exit();
                
            } else {
                return;
            }

        }
    }
}
