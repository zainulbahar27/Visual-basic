<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.log = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ex = New System.Windows.Forms.Button()
        Me.RRIdbDataSet = New try2_login.RRIdbDataSet()
        Me.Tb_adminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_adminTableAdapter = New try2_login.RRIdbDataSetTableAdapters.tb_adminTableAdapter()
        Me.TableAdapterManager = New try2_login.RRIdbDataSetTableAdapters.TableAdapterManager()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RRIdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_adminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "login.png")
        Me.ImageList1.Images.SetKeyName(1, "logout.png")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(414, 101)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-2, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'log
        '
        Me.log.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.log.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.log.ImageIndex = 0
        Me.log.ImageList = Me.ImageList1
        Me.log.Location = New System.Drawing.Point(185, 218)
        Me.log.Name = "log"
        Me.log.Size = New System.Drawing.Size(107, 52)
        Me.log.TabIndex = 3
        Me.log.Text = "Login"
        Me.log.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.log.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(185, 120)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(233, 31)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(185, 169)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(233, 31)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'ex
        '
        Me.ex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ex.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ex.ImageIndex = 1
        Me.ex.ImageList = Me.ImageList1
        Me.ex.Location = New System.Drawing.Point(311, 218)
        Me.ex.Name = "ex"
        Me.ex.Size = New System.Drawing.Size(107, 52)
        Me.ex.TabIndex = 7
        Me.ex.Text = "Exit"
        Me.ex.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ex.UseVisualStyleBackColor = True
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
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 294)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ex)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.log)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome To RRI Soccer Center"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RRIdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_adminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents log As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ex As System.Windows.Forms.Button
    Friend WithEvents RRIdbDataSet As try2_login.RRIdbDataSet
    Friend WithEvents Tb_adminBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_adminTableAdapter As try2_login.RRIdbDataSetTableAdapters.tb_adminTableAdapter
    Friend WithEvents TableAdapterManager As try2_login.RRIdbDataSetTableAdapters.TableAdapterManager

End Class
