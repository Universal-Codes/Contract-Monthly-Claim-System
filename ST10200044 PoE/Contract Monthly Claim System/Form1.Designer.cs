using System.Drawing;
using System.Windows.Forms;

namespace Contract_Monthly_Claim_System
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TabControl tabControl1;
        private TabPage tabLecturer;
        private TabPage tabCoordinator;
        private TabPage tabManager;

        // Lecturer controls
        private TableLayoutPanel tlpLecturerInput;
        private Label lblName;
        private Label lblSubject;
        private Label lblHours;
        private Label lblRate;
        private TextBox txtName;
        private TextBox txtSubject;
        private TextBox txtHours;
        private TextBox txtRate;
        private Button btnCalculate;
        private Button btnSubmit;
        private Button btnUpload;
        private Button btnTrackStatus;
        private DataGridView dgvLecturerClaims;
        private Label lblTotal;
        private OpenFileDialog openFileDialog1;

        // Coordinator controls
        private DataGridView dgvCoordinator;
        private Button btnApproveCoordinator;
        private Button btnRejectCoordinator;

        // Manager controls
        private DataGridView dgvManager;
        private Button btnApproveManager;
        private Button btnRejectManager;

        // Condition to clean up any resources being used.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.tabControl1 = new TabControl();
            this.tabLecturer = new TabPage();
            this.tabCoordinator = new TabPage();
            this.tabManager = new TabPage();

            // Lecturer controls
            this.tlpLecturerInput = new TableLayoutPanel();
            this.lblName = new Label();
            this.lblSubject = new Label();
            this.lblHours = new Label();
            this.lblRate = new Label();
            this.txtName = new TextBox();
            this.txtSubject = new TextBox();
            this.txtHours = new TextBox();
            this.txtRate = new TextBox();
            this.btnCalculate = new Button();
            this.btnSubmit = new Button();
            this.btnUpload = new Button();
            this.dgvLecturerClaims = new DataGridView();
            this.lblTotal = new Label();
            this.openFileDialog1 = new OpenFileDialog();

            // Coordinator controls
            this.dgvCoordinator = new DataGridView();
            this.btnApproveCoordinator = new Button();
            this.btnRejectCoordinator = new Button();

            // Manager controls
            this.dgvManager = new DataGridView();
            this.btnApproveManager = new Button();
            this.btnRejectManager = new Button();

            // Form
            this.Text = "CMCS - Prototype (Part 1) - UI Only";
            this.ClientSize = new Size(1000, 620);
            this.StartPosition = FormStartPosition.CenterScreen;

            // TabControl
            this.tabControl1.Dock = DockStyle.Fill;
            this.tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.tabControl1.TabPages.AddRange(new TabPage[] {
                this.tabLecturer,
                this.tabCoordinator,
                this.tabManager
            });

            // ---------- Lecturer Tab ----------
            this.tabLecturer.Text = "Lecturer Dashboard";
            this.tabLecturer.Padding = new Padding(10);

            // TableLayoutPanel for inputs
            this.tlpLecturerInput.ColumnCount = 2;
            this.tlpLecturerInput.RowCount = 4;
            this.tlpLecturerInput.Location = new Point(18, 18);
            this.tlpLecturerInput.Size = new Size(620, 160);
            this.tlpLecturerInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            this.tlpLecturerInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tlpLecturerInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            this.tlpLecturerInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            this.tlpLecturerInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            this.tlpLecturerInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));

            // Labels and TextBoxes
            this.lblName.Text = "Lecturer Name:";
            this.lblName.TextAlign = ContentAlignment.MiddleLeft;
            this.lblName.Dock = DockStyle.Fill;
            this.lblSubject.Text = "Subject:";
            this.lblSubject.TextAlign = ContentAlignment.MiddleLeft;
            this.lblSubject.Dock = DockStyle.Fill;
            this.lblHours.Text = "Hours Worked:";
            this.lblHours.TextAlign = ContentAlignment.MiddleLeft;
            this.lblHours.Dock = DockStyle.Fill;
            this.lblRate.Text = "Hourly Rate:";
            this.lblRate.TextAlign = ContentAlignment.MiddleLeft;
            this.lblRate.Dock = DockStyle.Fill;

            this.txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.txtSubject.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.txtHours.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.txtRate.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            this.tlpLecturerInput.Controls.Add(this.lblName, 0, 0);
            this.tlpLecturerInput.Controls.Add(this.txtName, 1, 0);
            this.tlpLecturerInput.Controls.Add(this.lblSubject, 0, 1);
            this.tlpLecturerInput.Controls.Add(this.txtSubject, 1, 1);
            this.tlpLecturerInput.Controls.Add(this.lblHours, 0, 2);
            this.tlpLecturerInput.Controls.Add(this.txtHours, 1, 2);
            this.tlpLecturerInput.Controls.Add(this.lblRate, 0, 3);
            this.tlpLecturerInput.Controls.Add(this.txtRate, 1, 3);

            // Buttons
            this.btnCalculate.Text = "Calculate Claim";
            this.btnCalculate.Size = new Size(120, 36);
            this.btnCalculate.Location = new Point(660, 30);
            this.btnCalculate.Enabled = false; // disable for prototype (no functionality)

            this.btnUpload.Text = "Upload Supporting Documents";
            this.btnUpload.Size = new Size(200, 36);
            this.btnUpload.Location = new Point(660, 78);
            this.btnUpload.Enabled = false; // // No funationality

            this.btnSubmit.Text = "Submit Claim";
            this.btnSubmit.Size = new Size(120, 36);
            this.btnSubmit.Location = new Point(660, 126);
            this.btnSubmit.Enabled = false; // No funationality

            // DataGridView for tracking claims
            this.dgvLecturerClaims.Location = new Point(18, 200);
            this.dgvLecturerClaims.Size = new Size(960, 300);
            this.dgvLecturerClaims.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvLecturerClaims.ReadOnly = true;
            this.dgvLecturerClaims.AllowUserToAddRows = false;
            this.dgvLecturerClaims.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvLecturerClaims.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Columns
            this.dgvLecturerClaims.Columns.Add("ClaimID", "Claim ID");
            this.dgvLecturerClaims.Columns.Add("LecturerName", "Lecturer Name");
            this.dgvLecturerClaims.Columns.Add("Subject", "Subject");
            this.dgvLecturerClaims.Columns.Add("HoursWorked", "Hours Worked");
            this.dgvLecturerClaims.Columns.Add("HourlyRate", "Hourly Rate");
            this.dgvLecturerClaims.Columns.Add("TotalPayment", "Total Payment");
            this.dgvLecturerClaims.Columns.Add("Status", "Status");

            // Total label
            this.lblTotal.Text = "Total Payment: R0.00";
            this.lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new Point(720, 520);
            this.lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            // Add controls to Lecturer tab
            this.tabLecturer.Controls.Add(this.tlpLecturerInput);
            this.tabLecturer.Controls.Add(this.btnCalculate);
            this.tabLecturer.Controls.Add(this.btnUpload);
            this.tabLecturer.Controls.Add(this.btnSubmit);
            this.tabLecturer.Controls.Add(this.dgvLecturerClaims);
            this.tabLecturer.Controls.Add(this.lblTotal);

            // ---------- Coordinator Tab ----------
            this.tabCoordinator.Text = "Programme Coordinator";
            this.tabCoordinator.Padding = new Padding(10);

            this.dgvCoordinator.Location = new Point(18, 18);
            this.dgvCoordinator.Size = new Size(720, 520);
            this.dgvCoordinator.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvCoordinator.ReadOnly = true;
            this.dgvCoordinator.AllowUserToAddRows = false;
            this.dgvCoordinator.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoordinator.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvCoordinator.Columns.Add("cClaimID", "Claim ID");
            this.dgvCoordinator.Columns.Add("cLecturerName", "Lecturer Name");
            this.dgvCoordinator.Columns.Add("cSubject", "Subject");
            this.dgvCoordinator.Columns.Add("cHours", "Hours");
            this.dgvCoordinator.Columns.Add("cRate", "Rate");
            this.dgvCoordinator.Columns.Add("cTotal", "Total");
            this.dgvCoordinator.Columns.Add("cStatus", "Status");

            this.btnApproveCoordinator.Text = "Approve";
            this.btnApproveCoordinator.Size = new Size(120, 36);
            this.btnApproveCoordinator.Location = new Point(760, 100);
            this.btnApproveCoordinator.Enabled = false;

            this.btnRejectCoordinator.Text = "Reject";
            this.btnRejectCoordinator.Size = new Size(120, 36);
            this.btnRejectCoordinator.Location = new Point(760, 100);
            this.btnRejectCoordinator.Enabled = false;

            this.tabCoordinator.Controls.Add(this.dgvCoordinator);
            this.tabCoordinator.Controls.Add(this.btnApproveCoordinator);
            this.tabCoordinator.Controls.Add(this.btnRejectCoordinator);

            // ---------- Manager Tab ----------
            this.tabManager.Text = "Academic Manager";
            this.tabManager.Padding = new Padding(10);

            this.dgvManager.Location = new Point(18, 18);
            this.dgvManager.Size = new Size(720, 520);
            this.dgvManager.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvManager.ReadOnly = true;
            this.dgvManager.AllowUserToAddRows = false;
            this.dgvManager.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvManager.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvManager.Columns.Add("mClaimID", "Claim ID");
            this.dgvManager.Columns.Add("mLecturerName", "Lecturer Name");
            this.dgvManager.Columns.Add("mSubject", "Subject");
            this.dgvManager.Columns.Add("mHours", "Hours");
            this.dgvManager.Columns.Add("mRate", "Rate");
            this.dgvManager.Columns.Add("mTotal", "Total");
            this.dgvManager.Columns.Add("mStatus", "Status");

            // Approval/Rejection Buttons
            this.btnApproveManager.Text = "Approve";
            this.btnApproveManager.Size = new Size(120, 36);
            this.btnApproveManager.Location = new Point(760, 100);
            this.btnApproveManager.Enabled = false;

            this.btnRejectManager.Text = "Reject";
            this.btnRejectManager.Size = new Size(120, 36);
            this.btnRejectManager.Location = new Point(760, 100);
            this.btnRejectManager.Enabled = false;

            this.tabManager.Controls.Add(this.dgvManager);
            this.tabManager.Controls.Add(this.btnApproveManager);
            this.tabManager.Controls.Add(this.btnRejectManager);

            // Add TabControl to form
            this.Controls.Add(this.tabControl1);

            // OpenFileDialog settings (for future use)
            this.openFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|Word files (*.docx)|*.docx|All files (*.*)|*.*";
            this.openFileDialog1.Multiselect = false;
        }
        #endregion
    }
}