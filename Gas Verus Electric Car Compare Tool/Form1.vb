Public Class Form1
    Dim DistancePerDay As Integer
    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim GasCostPerDay As Double
        Dim GasCostPerDay2 As Double
        Dim ElectricCostPerDay As Double

        'Do the calculations
        DistancePerDay = Double.Parse(DistancePerDayTextbox.Text)
        GasCostPerDay = CalculateGasCostPerYear()
        GasCostPerDay2 = CalculateGasCostPerYear2()
        ElectricCostPerDay = CalculateElectricCostPerYear()

        'Update the labels
        UpdateGasCostPerMileLabel(GasCostPerDay)
        UpdateGasCostPerMileLabel2(GasCostPerDay2)
        UpdateElectricCostPerMileLabel(ElectricCostPerDay)

        'Update the listboxes
        UpdateGasCostPerYearlistbox(GasCostPerDay * 365)
        UpdateGasCostPerYearlistbox2(GasCostPerDay2 * 365)
        UpdateElectricCostPerYearlistbox(ElectricCostPerDay * 365)

    End Sub
    Sub UpdateGasCostPerYearlistbox(Cost As Double)
        Dim InitialCost As Integer = Integer.Parse(InitialGasCarCostTextbox.Text)
        CostPerYearGasListbox.Items.Clear()

        For AYear = 1 To 10
            CostPerYearGasListbox.Items.Add("Year: " & AYear & " Cost is: " & FormatNumber(Cost * AYear + InitialCost, 2))
        Next

    End Sub
    Sub UpdateGasCostPerYearlistbox2(Cost As Double)
        Dim InitialCost As Integer = Integer.Parse(InitialGasCarCostTextbox2.Text)
        CostPerYearGasListbox2.Items.Clear()

        For AYear = 1 To 10
            CostPerYearGasListbox2.Items.Add("Year: " & AYear & " Cost is: " & FormatNumber(Cost * AYear + InitialCost, 2))
        Next

    End Sub
    Sub UpdateElectricCostPerYearlistbox(Cost As Double)
        Dim InitialCost As Integer = Integer.Parse(InitialElectricCarCostTextbox.Text)

        CostPerYearElectricListbox.Items.Clear()

        For AYear = 1 To 10
            CostPerYearElectricListbox.Items.Add("Year: " & AYear & " Cost is: " & FormatNumber(Cost * AYear + InitialCost, 2))
        Next

    End Sub

    Public Sub UpdateGasCostPerMileLabel(Cost As Double)
        GasCostPerMileLabel.Text = "Gas Cost Per Mile: " & FormatNumber(Cost, 2)
    End Sub
    Public Sub UpdateGasCostPerMileLabel2(Cost As Double)
        GasCostPerMileLabel2.Text = "Gas Cost Per Mile: " & FormatNumber(Cost, 2)
    End Sub
    Public Sub UpdateElectricCostPerMileLabel(Cost As Double)
        ElectricCostPerMileLabel.Text = "Electric Cost Per Mile: " & FormatNumber(Cost, 2)
    End Sub
    Function CalculateGasCostPerYear()
        Dim GasCost As Double = Double.Parse(GasCostTextbox.Text)
        Dim MPG As Integer = Integer.Parse(MPGTextbox.Text)

        Return GasCost * (DistancePerDay / MPG) 'Cost per Day
    End Function
    Function CalculateGasCostPerYear2()
        Dim GasCost As Double = Double.Parse(GasCostTextbox2.Text)
        Dim MPG As Integer = Integer.Parse(MPGTextbox2.Text)

        Return GasCost * (DistancePerDay / MPG) 'Cost per Day
    End Function
    Function CalculateElectricCostPerYear()
        Dim ElectricityCost As Double = Double.Parse(ElectricityCostTextbox.Text)
        Dim Range As Double = Double.Parse(ElectricRangeTextbox.Text)
        Dim BatteryCapacity As Double = Double.Parse(BatteryCapacityTextbox.Text)

        Return (DistancePerDay / Range) * BatteryCapacity * ElectricityCost 'Cost per Day
    End Function
End Class
