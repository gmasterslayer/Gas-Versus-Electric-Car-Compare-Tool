<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GasCostTextbox = New TextBox()
        GasCostLabel = New Label()
        ElectricityCostLabel = New Label()
        ElectricityCostTextbox = New TextBox()
        InitialGasCarCostLabel = New Label()
        InitialGasCarCostTextbox = New TextBox()
        InitialElectricCarCostLabel = New Label()
        InitialElectricCarCostTextbox = New TextBox()
        DistancePerDayLabel = New Label()
        DistancePerDayTextbox = New TextBox()
        MPGLabel = New Label()
        MPGTextbox = New TextBox()
        CostPerYearGasListbox = New ListBox()
        GasCostPerMileLabel = New Label()
        ElectricCostPerMileLabel = New Label()
        CostPerYearElectricListbox = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        Calculate = New Button()
        BatteryCapacityTextbox = New TextBox()
        BatteryCapacityLabel = New Label()
        ElectricRangeLabel = New Label()
        ElectricRangeTextbox = New TextBox()
        MPGLabel2 = New Label()
        MPGTextbox2 = New TextBox()
        InitialGasCarCostLabel2 = New Label()
        InitialGasCarCostTextbox2 = New TextBox()
        GasCostLabel2 = New Label()
        GasCostTextbox2 = New TextBox()
        GasCostPerMileLabel2 = New Label()
        Label3 = New Label()
        CostPerYearGasListbox2 = New ListBox()
        SuspendLayout()
        ' 
        ' GasCostTextbox
        ' 
        GasCostTextbox.Location = New Point(215, 54)
        GasCostTextbox.Name = "GasCostTextbox"
        GasCostTextbox.Size = New Size(125, 27)
        GasCostTextbox.TabIndex = 1
        ' 
        ' GasCostLabel
        ' 
        GasCostLabel.AutoSize = True
        GasCostLabel.Location = New Point(247, 21)
        GasCostLabel.Name = "GasCostLabel"
        GasCostLabel.Size = New Size(66, 20)
        GasCostLabel.TabIndex = 1
        GasCostLabel.Text = "Gas Cost"
        ' 
        ' ElectricityCostLabel
        ' 
        ElectricityCostLabel.AutoSize = True
        ElectricityCostLabel.Location = New Point(226, 119)
        ElectricityCostLabel.Name = "ElectricityCostLabel"
        ElectricityCostLabel.Size = New Size(176, 20)
        ElectricityCostLabel.TabIndex = 3
        ElectricityCostLabel.Text = "Electricity Cost per KW/H"
        ' 
        ' ElectricityCostTextbox
        ' 
        ElectricityCostTextbox.Location = New Point(247, 152)
        ElectricityCostTextbox.Name = "ElectricityCostTextbox"
        ElectricityCostTextbox.Size = New Size(125, 27)
        ElectricityCostTextbox.TabIndex = 4
        ' 
        ' InitialGasCarCostLabel
        ' 
        InitialGasCarCostLabel.AutoSize = True
        InitialGasCarCostLabel.Location = New Point(47, 21)
        InitialGasCarCostLabel.Name = "InitialGasCarCostLabel"
        InitialGasCarCostLabel.Size = New Size(143, 20)
        InitialGasCarCostLabel.TabIndex = 5
        InitialGasCarCostLabel.Text = "Initial Car Cost (Gas)"
        ' 
        ' InitialGasCarCostTextbox
        ' 
        InitialGasCarCostTextbox.Location = New Point(63, 54)
        InitialGasCarCostTextbox.Name = "InitialGasCarCostTextbox"
        InitialGasCarCostTextbox.Size = New Size(125, 27)
        InitialGasCarCostTextbox.TabIndex = 0
        ' 
        ' InitialElectricCarCostLabel
        ' 
        InitialElectricCarCostLabel.AutoSize = True
        InitialElectricCarCostLabel.Location = New Point(47, 119)
        InitialElectricCarCostLabel.Name = "InitialElectricCarCostLabel"
        InitialElectricCarCostLabel.Size = New Size(167, 20)
        InitialElectricCarCostLabel.TabIndex = 7
        InitialElectricCarCostLabel.Text = "Initial Car Cost (Electric)"
        ' 
        ' InitialElectricCarCostTextbox
        ' 
        InitialElectricCarCostTextbox.Location = New Point(64, 152)
        InitialElectricCarCostTextbox.Name = "InitialElectricCarCostTextbox"
        InitialElectricCarCostTextbox.Size = New Size(125, 27)
        InitialElectricCarCostTextbox.TabIndex = 3
        ' 
        ' DistancePerDayLabel
        ' 
        DistancePerDayLabel.AutoSize = True
        DistancePerDayLabel.Location = New Point(858, 93)
        DistancePerDayLabel.Name = "DistancePerDayLabel"
        DistancePerDayLabel.Size = New Size(163, 20)
        DistancePerDayLabel.TabIndex = 9
        DistancePerDayLabel.Text = "Distance Per Day (Mile)"
        ' 
        ' DistancePerDayTextbox
        ' 
        DistancePerDayTextbox.Location = New Point(875, 125)
        DistancePerDayTextbox.Name = "DistancePerDayTextbox"
        DistancePerDayTextbox.Size = New Size(125, 27)
        DistancePerDayTextbox.TabIndex = 7
        ' 
        ' MPGLabel
        ' 
        MPGLabel.AutoSize = True
        MPGLabel.Location = New Point(398, 21)
        MPGLabel.Name = "MPGLabel"
        MPGLabel.Size = New Size(40, 20)
        MPGLabel.TabIndex = 11
        MPGLabel.Text = "MPG"
        ' 
        ' MPGTextbox
        ' 
        MPGTextbox.Location = New Point(359, 54)
        MPGTextbox.Name = "MPGTextbox"
        MPGTextbox.Size = New Size(125, 27)
        MPGTextbox.TabIndex = 2
        ' 
        ' CostPerYearGasListbox
        ' 
        CostPerYearGasListbox.FormattingEnabled = True
        CostPerYearGasListbox.ItemHeight = 20
        CostPerYearGasListbox.Location = New Point(47, 429)
        CostPerYearGasListbox.Name = "CostPerYearGasListbox"
        CostPerYearGasListbox.Size = New Size(194, 164)
        CostPerYearGasListbox.TabIndex = 12
        CostPerYearGasListbox.TabStop = False
        ' 
        ' GasCostPerMileLabel
        ' 
        GasCostPerMileLabel.AutoSize = True
        GasCostPerMileLabel.Location = New Point(870, 225)
        GasCostPerMileLabel.Name = "GasCostPerMileLabel"
        GasCostPerMileLabel.Size = New Size(130, 20)
        GasCostPerMileLabel.TabIndex = 13
        GasCostPerMileLabel.Text = "Gas Cost Per Mile: "
        ' 
        ' ElectricCostPerMileLabel
        ' 
        ElectricCostPerMileLabel.AutoSize = True
        ElectricCostPerMileLabel.Location = New Point(846, 289)
        ElectricCostPerMileLabel.Name = "ElectricCostPerMileLabel"
        ElectricCostPerMileLabel.Size = New Size(154, 20)
        ElectricCostPerMileLabel.TabIndex = 14
        ElectricCostPerMileLabel.Text = "Electric Cost Per Mile: "
        ' 
        ' CostPerYearElectricListbox
        ' 
        CostPerYearElectricListbox.FormattingEnabled = True
        CostPerYearElectricListbox.ItemHeight = 20
        CostPerYearElectricListbox.Location = New Point(247, 429)
        CostPerYearElectricListbox.Name = "CostPerYearElectricListbox"
        CostPerYearElectricListbox.Size = New Size(216, 164)
        CostPerYearElectricListbox.TabIndex = 19
        CostPerYearElectricListbox.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(47, 392)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 20)
        Label1.TabIndex = 21
        Label1.Text = "Cost Per Year (Gas)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(247, 392)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 20)
        Label2.TabIndex = 22
        Label2.Text = "Cost Per Year (Electric)"
        ' 
        ' Calculate
        ' 
        Calculate.Location = New Point(798, 470)
        Calculate.Name = "Calculate"
        Calculate.Size = New Size(94, 31)
        Calculate.TabIndex = 11
        Calculate.Text = "Calculate"
        Calculate.UseVisualStyleBackColor = True
        ' 
        ' BatteryCapacityTextbox
        ' 
        BatteryCapacityTextbox.Location = New Point(414, 152)
        BatteryCapacityTextbox.Name = "BatteryCapacityTextbox"
        BatteryCapacityTextbox.Size = New Size(125, 27)
        BatteryCapacityTextbox.TabIndex = 5
        ' 
        ' BatteryCapacityLabel
        ' 
        BatteryCapacityLabel.AutoSize = True
        BatteryCapacityLabel.Location = New Point(425, 119)
        BatteryCapacityLabel.Name = "BatteryCapacityLabel"
        BatteryCapacityLabel.Size = New Size(117, 20)
        BatteryCapacityLabel.TabIndex = 18
        BatteryCapacityLabel.Text = "Battery Capacity"
        ' 
        ' ElectricRangeLabel
        ' 
        ElectricRangeLabel.AutoSize = True
        ElectricRangeLabel.Location = New Point(594, 119)
        ElectricRangeLabel.Name = "ElectricRangeLabel"
        ElectricRangeLabel.Size = New Size(51, 20)
        ElectricRangeLabel.TabIndex = 25
        ElectricRangeLabel.Text = "Range"
        ' 
        ' ElectricRangeTextbox
        ' 
        ElectricRangeTextbox.Location = New Point(559, 152)
        ElectricRangeTextbox.Name = "ElectricRangeTextbox"
        ElectricRangeTextbox.Size = New Size(125, 27)
        ElectricRangeTextbox.TabIndex = 6
        ' 
        ' MPGLabel2
        ' 
        MPGLabel2.AutoSize = True
        MPGLabel2.Location = New Point(398, 215)
        MPGLabel2.Name = "MPGLabel2"
        MPGLabel2.Size = New Size(52, 20)
        MPGLabel2.TabIndex = 31
        MPGLabel2.Text = "MPG 2"
        ' 
        ' MPGTextbox2
        ' 
        MPGTextbox2.Location = New Point(359, 248)
        MPGTextbox2.Name = "MPGTextbox2"
        MPGTextbox2.Size = New Size(125, 27)
        MPGTextbox2.TabIndex = 10
        ' 
        ' InitialGasCarCostLabel2
        ' 
        InitialGasCarCostLabel2.AutoSize = True
        InitialGasCarCostLabel2.Location = New Point(47, 215)
        InitialGasCarCostLabel2.Name = "InitialGasCarCostLabel2"
        InitialGasCarCostLabel2.Size = New Size(155, 20)
        InitialGasCarCostLabel2.TabIndex = 30
        InitialGasCarCostLabel2.Text = "Initial Car Cost 2 (Gas)"
        ' 
        ' InitialGasCarCostTextbox2
        ' 
        InitialGasCarCostTextbox2.Location = New Point(63, 248)
        InitialGasCarCostTextbox2.Name = "InitialGasCarCostTextbox2"
        InitialGasCarCostTextbox2.Size = New Size(125, 27)
        InitialGasCarCostTextbox2.TabIndex = 8
        ' 
        ' GasCostLabel2
        ' 
        GasCostLabel2.AutoSize = True
        GasCostLabel2.Location = New Point(247, 215)
        GasCostLabel2.Name = "GasCostLabel2"
        GasCostLabel2.Size = New Size(66, 20)
        GasCostLabel2.TabIndex = 27
        GasCostLabel2.Text = "Gas Cost"
        ' 
        ' GasCostTextbox2
        ' 
        GasCostTextbox2.Location = New Point(215, 248)
        GasCostTextbox2.Name = "GasCostTextbox2"
        GasCostTextbox2.Size = New Size(125, 27)
        GasCostTextbox2.TabIndex = 9
        ' 
        ' GasCostPerMileLabel2
        ' 
        GasCostPerMileLabel2.AutoSize = True
        GasCostPerMileLabel2.Location = New Point(859, 255)
        GasCostPerMileLabel2.Name = "GasCostPerMileLabel2"
        GasCostPerMileLabel2.Size = New Size(142, 20)
        GasCostPerMileLabel2.TabIndex = 32
        GasCostPerMileLabel2.Text = "Gas Cost 2 Per Mile: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(469, 392)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 20)
        Label3.TabIndex = 34
        Label3.Text = "Cost Per Year 2 (Gas)"
        ' 
        ' CostPerYearGasListbox2
        ' 
        CostPerYearGasListbox2.FormattingEnabled = True
        CostPerYearGasListbox2.ItemHeight = 20
        CostPerYearGasListbox2.Location = New Point(469, 429)
        CostPerYearGasListbox2.Name = "CostPerYearGasListbox2"
        CostPerYearGasListbox2.Size = New Size(194, 164)
        CostPerYearGasListbox2.TabIndex = 33
        CostPerYearGasListbox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1140, 631)
        Controls.Add(Label3)
        Controls.Add(CostPerYearGasListbox2)
        Controls.Add(GasCostPerMileLabel2)
        Controls.Add(MPGLabel2)
        Controls.Add(MPGTextbox2)
        Controls.Add(InitialGasCarCostLabel2)
        Controls.Add(InitialGasCarCostTextbox2)
        Controls.Add(GasCostLabel2)
        Controls.Add(GasCostTextbox2)
        Controls.Add(ElectricRangeLabel)
        Controls.Add(ElectricRangeTextbox)
        Controls.Add(Calculate)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CostPerYearElectricListbox)
        Controls.Add(BatteryCapacityLabel)
        Controls.Add(BatteryCapacityTextbox)
        Controls.Add(ElectricCostPerMileLabel)
        Controls.Add(GasCostPerMileLabel)
        Controls.Add(CostPerYearGasListbox)
        Controls.Add(MPGLabel)
        Controls.Add(MPGTextbox)
        Controls.Add(DistancePerDayLabel)
        Controls.Add(DistancePerDayTextbox)
        Controls.Add(InitialElectricCarCostLabel)
        Controls.Add(InitialElectricCarCostTextbox)
        Controls.Add(InitialGasCarCostLabel)
        Controls.Add(InitialGasCarCostTextbox)
        Controls.Add(ElectricityCostLabel)
        Controls.Add(ElectricityCostTextbox)
        Controls.Add(GasCostLabel)
        Controls.Add(GasCostTextbox)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GasCostTextbox As TextBox
    Friend WithEvents GasCostLabel As Label
    Friend WithEvents ElectricityCostLabel As Label
    Friend WithEvents ElectricityCostTextbox As TextBox
    Friend WithEvents InitialGasCarCostLabel As Label
    Friend WithEvents InitialGasCarCostTextbox As TextBox
    Friend WithEvents InitialElectricCarCostLabel As Label
    Friend WithEvents InitialElectricCarCostTextbox As TextBox
    Friend WithEvents DistancePerDayLabel As Label
    Friend WithEvents DistancePerDayTextbox As TextBox
    Friend WithEvents MPGLabel As Label
    Friend WithEvents MPGTextbox As TextBox
    Friend WithEvents CostPerYearGasListbox As ListBox
    Friend WithEvents GasCostPerMileLabel As Label
    Friend WithEvents ElectricCostPerMileLabel As Label
    Friend WithEvents CostPerYearElectricListbox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Calculate As Button
    Friend WithEvents BatteryCapacityTextbox As TextBox
    Friend WithEvents BatteryCapacityLabel As Label
    Friend WithEvents ElectricRangeLabel As Label
    Friend WithEvents ElectricRangeTextbox As TextBox
    Friend WithEvents MPGLabel2 As Label
    Friend WithEvents MPGTextbox2 As TextBox
    Friend WithEvents InitialGasCarCostLabel2 As Label
    Friend WithEvents InitialGasCarCostTextbox2 As TextBox
    Friend WithEvents GasCostLabel2 As Label
    Friend WithEvents GasCostTextbox2 As TextBox
    Friend WithEvents GasCostPerMileLabel2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CostPerYearGasListbox2 As ListBox
End Class
