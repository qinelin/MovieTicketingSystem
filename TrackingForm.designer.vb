﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrackingForm
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrackingForm))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.BtnEnd = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.BookingAndEventsDataSet = New Main.BookingAndEventsDataSet()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableTableAdapter = New Main.BookingAndEventsDataSetTableAdapters.TableTableAdapter()
        Me.訂單編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.日期DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.電影名稱DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.票種DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.座位DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.影廳DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.場次DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.距離觀影日還有幾天DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingAndEventsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(100, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "輸入電話："
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(239, 109)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(359, 33)
        Me.TextBox1.TabIndex = 3
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Location = New System.Drawing.Point(632, 109)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(100, 33)
        Me.BtnSearch.TabIndex = 4
        Me.BtnSearch.Text = "搜尋"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 172)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(821, 327)
        Me.DataGridView1.TabIndex = 5
        '
        'BtnMenu
        '
        Me.BtnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMenu.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnMenu.Location = New System.Drawing.Point(21, 518)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(124, 48)
        Me.BtnMenu.TabIndex = 22
        Me.BtnMenu.Text = "回主選單"
        Me.BtnMenu.UseVisualStyleBackColor = False
        '
        'BtnEnd
        '
        Me.BtnEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnEnd.FlatAppearance.BorderSize = 0
        Me.BtnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnd.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BtnEnd.ForeColor = System.Drawing.Color.Black
        Me.BtnEnd.Location = New System.Drawing.Point(690, 518)
        Me.BtnEnd.Name = "BtnEnd"
        Me.BtnEnd.Size = New System.Drawing.Size(152, 48)
        Me.BtnEnd.TabIndex = 27
        Me.BtnEnd.Text = "結束"
        Me.BtnEnd.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.訂單編號DataGridViewTextBoxColumn, Me.日期DataGridViewTextBoxColumn, Me.電影名稱DataGridViewTextBoxColumn, Me.票種DataGridViewTextBoxColumn, Me.座位DataGridViewTextBoxColumn, Me.影廳DataGridViewTextBoxColumn, Me.場次DataGridViewTextBoxColumn, Me.距離觀影日還有幾天DataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.TableBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(21, 172)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(821, 327)
        Me.DataGridView2.TabIndex = 28
        '
        'BookingAndEventsDataSet
        '
        Me.BookingAndEventsDataSet.DataSetName = "BookingAndEventsDataSet"
        Me.BookingAndEventsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.BookingAndEventsDataSet
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        '訂單編號DataGridViewTextBoxColumn
        '
        Me.訂單編號DataGridViewTextBoxColumn.DataPropertyName = "訂單編號"
        Me.訂單編號DataGridViewTextBoxColumn.HeaderText = "訂單編號"
        Me.訂單編號DataGridViewTextBoxColumn.Name = "訂單編號DataGridViewTextBoxColumn"
        Me.訂單編號DataGridViewTextBoxColumn.ReadOnly = True
        '
        '日期DataGridViewTextBoxColumn
        '
        Me.日期DataGridViewTextBoxColumn.DataPropertyName = "日期"
        Me.日期DataGridViewTextBoxColumn.HeaderText = "日期"
        Me.日期DataGridViewTextBoxColumn.Name = "日期DataGridViewTextBoxColumn"
        '
        '電影名稱DataGridViewTextBoxColumn
        '
        Me.電影名稱DataGridViewTextBoxColumn.DataPropertyName = "電影名稱"
        Me.電影名稱DataGridViewTextBoxColumn.HeaderText = "電影名稱"
        Me.電影名稱DataGridViewTextBoxColumn.Name = "電影名稱DataGridViewTextBoxColumn"
        '
        '票種DataGridViewTextBoxColumn
        '
        Me.票種DataGridViewTextBoxColumn.DataPropertyName = "票種"
        Me.票種DataGridViewTextBoxColumn.HeaderText = "票種"
        Me.票種DataGridViewTextBoxColumn.Name = "票種DataGridViewTextBoxColumn"
        '
        '座位DataGridViewTextBoxColumn
        '
        Me.座位DataGridViewTextBoxColumn.DataPropertyName = "座位"
        Me.座位DataGridViewTextBoxColumn.HeaderText = "座位"
        Me.座位DataGridViewTextBoxColumn.Name = "座位DataGridViewTextBoxColumn"
        '
        '影廳DataGridViewTextBoxColumn
        '
        Me.影廳DataGridViewTextBoxColumn.DataPropertyName = "影廳"
        Me.影廳DataGridViewTextBoxColumn.HeaderText = "影廳"
        Me.影廳DataGridViewTextBoxColumn.Name = "影廳DataGridViewTextBoxColumn"
        '
        '場次DataGridViewTextBoxColumn
        '
        Me.場次DataGridViewTextBoxColumn.DataPropertyName = "場次"
        Me.場次DataGridViewTextBoxColumn.HeaderText = "場次"
        Me.場次DataGridViewTextBoxColumn.Name = "場次DataGridViewTextBoxColumn"
        '
        '距離觀影日還有幾天DataGridViewTextBoxColumn
        '
        Me.距離觀影日還有幾天DataGridViewTextBoxColumn.DataPropertyName = "距離觀影日還有幾天"
        Me.距離觀影日還有幾天DataGridViewTextBoxColumn.HeaderText = "距離觀影日還有幾天"
        Me.距離觀影日還有幾天DataGridViewTextBoxColumn.Name = "距離觀影日還有幾天DataGridViewTextBoxColumn"
        '
        'TrackingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(854, 591)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.BtnEnd)
        Me.Controls.Add(Me.BtnMenu)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "TrackingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TrackingForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingAndEventsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnMenu As Button
    Friend WithEvents BtnEnd As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents BookingAndEventsDataSet As BookingAndEventsDataSet
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableTableAdapter As BookingAndEventsDataSetTableAdapters.TableTableAdapter
    Friend WithEvents 訂單編號DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 日期DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 電影名稱DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 票種DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 座位DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 影廳DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 場次DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 距離觀影日還有幾天DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
