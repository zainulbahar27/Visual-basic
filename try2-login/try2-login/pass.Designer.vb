<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pass))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.passlama = New System.Windows.Forms.TextBox()
        Me.passbaru = New System.Windows.Forms.TextBox()
        Me.konfirm = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RRIdbDataSet = New try2_login.RRIdbDataSet()
        Me.Tb_adminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_adminTableAdapter = New try2_login.RRIdbDataSetTableAdapters.tb_adminTableAdapter()
        Me.TableAdapterManager = New try2_login.RRIdbDataSetTableAdapters.TableAdapterManager()
        Me.hidden = New System.Windows.Forms.Label()
        CType(Me.RRIdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_adminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "cancel-button.png")
        Me.ImageList1.Images.SetKeyName(1, "confirm-purchase.png")
        Me.ImageList1.Images.SetKeyName(2, "cancel.png")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password Lama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password Baru"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Konfirmasi Password "
        '
        'passlama
        '
        Me.passlama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passlama.Location = New System.Drawing.Point(231, 9)
        Me.passlama.Name = "passlama"
        Me.passlama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passlama.Size = New System.Drawing.Size(234, 26)
        Me.passlama.TabIndex = 3
        Me.passlama.UseSystemPasswordChar = True
        '
        'passbaru
        '
        Me.passbaru.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passbaru.Location = New System.Drawing.Point(231, 53)
        Me.passbaru.Name = "passbaru"
        Me.passbaru.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passbaru.Size = New System.Drawing.Size(234, 26)
        Me.passbaru.TabIndex = 4
        Me.passbaru.UseSystemPasswordChar = True
        '
        'konfirm
        '
        Me.konfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.konfirm.Location = New System.Drawing.Point(231, 99)
        Me.konfirm.Name = "konfirm"
        Me.konfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.konfirm.Size = New System.Drawing.Size(234, 26)
        Me.konfirm.TabIndex = 5
        Me.konfirm.UseSystemPasswordChar = True
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.ImageIndex = 1
        Me.Button8.ImageList = Me.ImageList1
        Me.Button8.Location = New System.Drawing.Point(231, 143)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(110, 38)
        Me.Button8.TabIndex = 10
        Me.Button8.Text = "Selesai"
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageIndex = 2
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(355, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 38)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Cancel"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RRIdbDataSet
        '
        Me.RRIdbDataSet.DataSetName = "RRIdbDataSet"
        Me.RRIdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_adminBindingSource
        '
        Me.Tb_adminBindingSource.DataMember = "tb_admin"
        Me.Tb_adminBindingSource.DataSource = Me.RRIdbDataSet
        '
        'Tb_adminTableAdapter
        '
        Me.Tb_adminTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DataTableAdapter = Nothing
        Me.TableAdapterManager.HargaTableAdapter = Nothing
        Me.TableAdapterManager.LapanganTableAdapter = Nothing
        Me.TableAdapterManager.MamberTableAdapter = Nothing
        Me.TableAdapterManager.PemesananTableAdapter = Nothing
        Me.TableAdapterManager.tb_adminTableAdapter = Me.Tb_adminTableAdapter
        Me.TableAdapterManager.UpdateOrder = try2_login.RRIdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'hidden
        '
        Me.hidden.AutoSize = True
        Me.hidden.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_adminBindingSource, "pass", True))
        Me.hidden.Location = New System.Drawing.Point(37, 143)
        Me.hidden.Name = "hidden"
        Me.hidden.Size = New System.Drawing.Size(39, 13)
        Me.hidden.TabIndex = 12
        Me.hidden.Text = "Label4"
        Me.hidden.Visible = False
        '
        'pass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(489, 197)
        Me.Controls.Add(Me.hidden)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.konfirm)
        Me.Controls.Add(Me.passbaru)
        Me.Controls.Add(Me.passlama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "pass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pass"
        CType(Me.RRIdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_adminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents passlama As System.Windows.Forms.TextBox
    Friend WithEvents passbaru As System.Windows.Forms.TextBox
    Friend WithEvents konfirm As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RRIdbDataSet As try2_login.RRIdbDataSet
    Friend WithEvents Tb_adminBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_adminTableAdapter As try2_login.RRIdbDataSetTableAdapters.tb_adminTableAdapter
    Friend WithEvents TableAdapterManager As try2_login.RRIdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents hidden As System.Windows.Forms.Label
End Class
