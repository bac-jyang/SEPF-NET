<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParticipantInfo
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
        Dim Participant_SSNLabel As System.Windows.Forms.Label
        Dim Participant_FirstNameLabel As System.Windows.Forms.Label
        Dim Participant_MInitialLabel As System.Windows.Forms.Label
        Dim Participant_LastNameLabel As System.Windows.Forms.Label
        Dim Participant_Address1Label As System.Windows.Forms.Label
        Dim Participant_Address2Label As System.Windows.Forms.Label
        Dim Participant_CityLabel As System.Windows.Forms.Label
        Dim Participant_State_CodeLabel As System.Windows.Forms.Label
        Dim Participant_CountryLabel As System.Windows.Forms.Label
        Dim Participant_PhoneLabel As System.Windows.Forms.Label
        Dim Participant_EmailLabel As System.Windows.Forms.Label
        Dim Participant_DOBLabel As System.Windows.Forms.Label
        Dim Participant_Date_HiredLabel As System.Windows.Forms.Label
        Dim Participant_DODLabel As System.Windows.Forms.Label
        Dim Participant_Termination_DateLabel As System.Windows.Forms.Label
        Dim Participant_Rehire_DateLabel As System.Windows.Forms.Label
        Dim Participant_Date_Last_ModifiedLabel As System.Windows.Forms.Label
        Dim Participant_Base_EarningLabel As System.Windows.Forms.Label
        Dim Participant_Base_Effective_DateLabel As System.Windows.Forms.Label
        Dim Participant_First_Contribution_DateLabel As System.Windows.Forms.Label
        Dim Participant_Last_Contribution_DateLabel As System.Windows.Forms.Label
        Dim ITDContributionLabel As System.Windows.Forms.Label
        Dim Participant_ITD_Pension_ContributionLabel As System.Windows.Forms.Label
        Dim Participant_ITD_Insurance_DeductionLabel As System.Windows.Forms.Label
        Dim Participant_Pension_SuspensionLabel As System.Windows.Forms.Label
        Dim Participant_Pension_ReinstatementLabel As System.Windows.Forms.Label
        Dim Participant_Participation_dateLabel As System.Windows.Forms.Label
        Dim Participant_Retirement_DateLabel As System.Windows.Forms.Label
        Dim Participant_Lump_Sum_PaymentLabel As System.Windows.Forms.Label
        Dim Participant_Lump_Sum_Payment_FlagLabel As System.Windows.Forms.Label
        Dim FutureServiceCreditLabel As System.Windows.Forms.Label
        Dim YearsOfServiceLabel As System.Windows.Forms.Label
        Dim MonthsOfServiceLabel As System.Windows.Forms.Label
        Dim TotalServiceCreditLabel As System.Windows.Forms.Label
        Dim Participant_Award_DateLabel As System.Windows.Forms.Label
        Dim Participant_ITD_Benefits_PaidLabel As System.Windows.Forms.Label
        Dim Participant_Last_Check_DateLabel As System.Windows.Forms.Label
        Dim Participant_QDR_DateLabel As System.Windows.Forms.Label
        Dim Participant_QDR_AmountLabel As System.Windows.Forms.Label
        Dim Participant_QDR_FlagLabel As System.Windows.Forms.Label
        Dim Participant_OptionLabel As System.Windows.Forms.Label
        Dim Participant_Pension_TypeLabel As System.Windows.Forms.Label
        Dim Participant_Country_CodeLabel As System.Windows.Forms.Label
        Dim Participant_FundLabel As System.Windows.Forms.Label
        Dim Participant_Zip_CodeLabel As System.Windows.Forms.Label
        Dim Participant_OrganizationLabel As System.Windows.Forms.Label
        Dim Participant_StatusLabel As System.Windows.Forms.Label
        Dim Participant_Martial_StatusLabel As System.Windows.Forms.Label
        Dim Participant_OE_FlagLabel As System.Windows.Forms.Label
        Dim VestedLabel As System.Windows.Forms.Label
        Dim Participant_Pay_FrequencyLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Name = New System.Windows.Forms.ComboBox()
        Me.Participant_Pay_Frequency = New System.Windows.Forms.ComboBox()
        Me.Vested = New System.Windows.Forms.ComboBox()
        Me.Participant_OE_Flag = New System.Windows.Forms.ComboBox()
        Me.Participant_Martial_Status = New System.Windows.Forms.ComboBox()
        Me.Participant_Status = New System.Windows.Forms.ComboBox()
        Me.Participant_Organization = New System.Windows.Forms.ComboBox()
        Me.Participant_Zip_Code = New System.Windows.Forms.ComboBox()
        Me.Participant_Fund = New System.Windows.Forms.ComboBox()
        Me.Participant_Country_Code = New System.Windows.Forms.ComboBox()
        Me.Participant_Date_Last_ModifiedDate = New System.Windows.Forms.DateTimePicker()
        Me.Participant_Rehire_DateDate = New System.Windows.Forms.DateTimePicker()
        Me.Participant_Termination_DateDate = New System.Windows.Forms.DateTimePicker()
        Me.Participant_DODDate = New System.Windows.Forms.DateTimePicker()
        Me.Participant_Date_HiredDate = New System.Windows.Forms.DateTimePicker()
        Me.Participant_DOBDate = New System.Windows.Forms.DateTimePicker()
        Me.Participant_Email = New System.Windows.Forms.TextBox()
        Me.Participant_Phone = New System.Windows.Forms.TextBox()
        Me.Participant_Country = New System.Windows.Forms.TextBox()
        Me.Participant_State_Code = New System.Windows.Forms.TextBox()
        Me.Participant_City = New System.Windows.Forms.TextBox()
        Me.Participant_Address2 = New System.Windows.Forms.TextBox()
        Me.Participant_Address1 = New System.Windows.Forms.TextBox()
        Me.Participant_LastName = New System.Windows.Forms.TextBox()
        Me.Participant_MInitial = New System.Windows.Forms.TextBox()
        Me.Participant_FirstName = New System.Windows.Forms.TextBox()
        Me.Participant_SSN = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Participant_Pension_Type = New System.Windows.Forms.ComboBox()
        Me.Participant_Option = New System.Windows.Forms.ComboBox()
        Me.Participant_QDR_Flag = New System.Windows.Forms.ComboBox()
        Me.Participant_QDR_Amount = New System.Windows.Forms.TextBox()
        Me.Participant_QDR_Date = New System.Windows.Forms.DateTimePicker()
        Me.Participant_Last_Check_Date = New System.Windows.Forms.DateTimePicker()
        Me.Participant_ITD_Benefits_Paid = New System.Windows.Forms.TextBox()
        Me.Participant_Award_Date = New System.Windows.Forms.DateTimePicker()
        Me.TotalServiceCredit = New System.Windows.Forms.TextBox()
        Me.MonthsOfService = New System.Windows.Forms.TextBox()
        Me.YearsOfService = New System.Windows.Forms.TextBox()
        Me.FutureServiceCredit = New System.Windows.Forms.TextBox()
        Me.Participant_Lump_Sum_Payment_Flag = New System.Windows.Forms.TextBox()
        Me.Participant_Lump_Sum_Payment = New System.Windows.Forms.TextBox()
        Me.Participant_Retirement_Date = New System.Windows.Forms.DateTimePicker()
        Me.Participant_Participation_date = New System.Windows.Forms.DateTimePicker()
        Me.Participant_Pension_Reinstatement = New System.Windows.Forms.DateTimePicker()
        Me.Participant_Pension_Suspension = New System.Windows.Forms.DateTimePicker()
        Me.Participant_ITD_Insurance_Deduction = New System.Windows.Forms.TextBox()
        Me.Participant_ITD_Pension_Contribution = New System.Windows.Forms.TextBox()
        Me.ITDContribution = New System.Windows.Forms.TextBox()
        Me.Participant_Last_Contribution_Date = New System.Windows.Forms.DateTimePicker()
        Me.Participant_First_Contribution_Date = New System.Windows.Forms.DateTimePicker()
        Me.Participant_Base_Effective_Date = New System.Windows.Forms.DateTimePicker()
        Me.Participant_Base_Earning = New System.Windows.Forms.TextBox()
        Participant_SSNLabel = New System.Windows.Forms.Label()
        Participant_FirstNameLabel = New System.Windows.Forms.Label()
        Participant_MInitialLabel = New System.Windows.Forms.Label()
        Participant_LastNameLabel = New System.Windows.Forms.Label()
        Participant_Address1Label = New System.Windows.Forms.Label()
        Participant_Address2Label = New System.Windows.Forms.Label()
        Participant_CityLabel = New System.Windows.Forms.Label()
        Participant_State_CodeLabel = New System.Windows.Forms.Label()
        Participant_CountryLabel = New System.Windows.Forms.Label()
        Participant_PhoneLabel = New System.Windows.Forms.Label()
        Participant_EmailLabel = New System.Windows.Forms.Label()
        Participant_DOBLabel = New System.Windows.Forms.Label()
        Participant_Date_HiredLabel = New System.Windows.Forms.Label()
        Participant_DODLabel = New System.Windows.Forms.Label()
        Participant_Termination_DateLabel = New System.Windows.Forms.Label()
        Participant_Rehire_DateLabel = New System.Windows.Forms.Label()
        Participant_Date_Last_ModifiedLabel = New System.Windows.Forms.Label()
        Participant_Base_EarningLabel = New System.Windows.Forms.Label()
        Participant_Base_Effective_DateLabel = New System.Windows.Forms.Label()
        Participant_First_Contribution_DateLabel = New System.Windows.Forms.Label()
        Participant_Last_Contribution_DateLabel = New System.Windows.Forms.Label()
        ITDContributionLabel = New System.Windows.Forms.Label()
        Participant_ITD_Pension_ContributionLabel = New System.Windows.Forms.Label()
        Participant_ITD_Insurance_DeductionLabel = New System.Windows.Forms.Label()
        Participant_Pension_SuspensionLabel = New System.Windows.Forms.Label()
        Participant_Pension_ReinstatementLabel = New System.Windows.Forms.Label()
        Participant_Participation_dateLabel = New System.Windows.Forms.Label()
        Participant_Retirement_DateLabel = New System.Windows.Forms.Label()
        Participant_Lump_Sum_PaymentLabel = New System.Windows.Forms.Label()
        Participant_Lump_Sum_Payment_FlagLabel = New System.Windows.Forms.Label()
        FutureServiceCreditLabel = New System.Windows.Forms.Label()
        YearsOfServiceLabel = New System.Windows.Forms.Label()
        MonthsOfServiceLabel = New System.Windows.Forms.Label()
        TotalServiceCreditLabel = New System.Windows.Forms.Label()
        Participant_Award_DateLabel = New System.Windows.Forms.Label()
        Participant_ITD_Benefits_PaidLabel = New System.Windows.Forms.Label()
        Participant_Last_Check_DateLabel = New System.Windows.Forms.Label()
        Participant_QDR_DateLabel = New System.Windows.Forms.Label()
        Participant_QDR_AmountLabel = New System.Windows.Forms.Label()
        Participant_QDR_FlagLabel = New System.Windows.Forms.Label()
        Participant_OptionLabel = New System.Windows.Forms.Label()
        Participant_Pension_TypeLabel = New System.Windows.Forms.Label()
        Participant_Country_CodeLabel = New System.Windows.Forms.Label()
        Participant_FundLabel = New System.Windows.Forms.Label()
        Participant_Zip_CodeLabel = New System.Windows.Forms.Label()
        Participant_OrganizationLabel = New System.Windows.Forms.Label()
        Participant_StatusLabel = New System.Windows.Forms.Label()
        Participant_Martial_StatusLabel = New System.Windows.Forms.Label()
        Participant_OE_FlagLabel = New System.Windows.Forms.Label()
        VestedLabel = New System.Windows.Forms.Label()
        Participant_Pay_FrequencyLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Participant_SSNLabel
        '
        Participant_SSNLabel.AutoSize = True
        Participant_SSNLabel.Location = New System.Drawing.Point(259, 31)
        Participant_SSNLabel.Name = "Participant_SSNLabel"
        Participant_SSNLabel.Size = New System.Drawing.Size(111, 17)
        Participant_SSNLabel.TabIndex = 2
        Participant_SSNLabel.Text = "Participant SSN:"
        '
        'Participant_FirstNameLabel
        '
        Participant_FirstNameLabel.AutoSize = True
        Participant_FirstNameLabel.Location = New System.Drawing.Point(18, 56)
        Participant_FirstNameLabel.Name = "Participant_FirstNameLabel"
        Participant_FirstNameLabel.Size = New System.Drawing.Size(151, 17)
        Participant_FirstNameLabel.TabIndex = 8
        Participant_FirstNameLabel.Text = "Participant First Name:"
        '
        'Participant_MInitialLabel
        '
        Participant_MInitialLabel.AutoSize = True
        Participant_MInitialLabel.Location = New System.Drawing.Point(289, 60)
        Participant_MInitialLabel.Name = "Participant_MInitialLabel"
        Participant_MInitialLabel.Size = New System.Drawing.Size(126, 17)
        Participant_MInitialLabel.TabIndex = 10
        Participant_MInitialLabel.Text = "Participant MInitial:"
        '
        'Participant_LastNameLabel
        '
        Participant_LastNameLabel.AutoSize = True
        Participant_LastNameLabel.Location = New System.Drawing.Point(468, 64)
        Participant_LastNameLabel.Name = "Participant_LastNameLabel"
        Participant_LastNameLabel.Size = New System.Drawing.Size(151, 17)
        Participant_LastNameLabel.TabIndex = 12
        Participant_LastNameLabel.Text = "Participant Last Name:"
        '
        'Participant_Address1Label
        '
        Participant_Address1Label.AutoSize = True
        Participant_Address1Label.Location = New System.Drawing.Point(19, 88)
        Participant_Address1Label.Name = "Participant_Address1Label"
        Participant_Address1Label.Size = New System.Drawing.Size(143, 17)
        Participant_Address1Label.TabIndex = 14
        Participant_Address1Label.Text = "Participant Address1:"
        '
        'Participant_Address2Label
        '
        Participant_Address2Label.AutoSize = True
        Participant_Address2Label.Location = New System.Drawing.Point(25, 123)
        Participant_Address2Label.Name = "Participant_Address2Label"
        Participant_Address2Label.Size = New System.Drawing.Size(143, 17)
        Participant_Address2Label.TabIndex = 16
        Participant_Address2Label.Text = "Participant Address2:"
        '
        'Participant_CityLabel
        '
        Participant_CityLabel.AutoSize = True
        Participant_CityLabel.Location = New System.Drawing.Point(27, 153)
        Participant_CityLabel.Name = "Participant_CityLabel"
        Participant_CityLabel.Size = New System.Drawing.Size(106, 17)
        Participant_CityLabel.TabIndex = 18
        Participant_CityLabel.Text = "Participant City:"
        '
        'Participant_State_CodeLabel
        '
        Participant_State_CodeLabel.AutoSize = True
        Participant_State_CodeLabel.Location = New System.Drawing.Point(248, 158)
        Participant_State_CodeLabel.Name = "Participant_State_CodeLabel"
        Participant_State_CodeLabel.Size = New System.Drawing.Size(153, 17)
        Participant_State_CodeLabel.TabIndex = 20
        Participant_State_CodeLabel.Text = "Participant State Code:"
        '
        'Participant_CountryLabel
        '
        Participant_CountryLabel.AutoSize = True
        Participant_CountryLabel.Location = New System.Drawing.Point(37, 206)
        Participant_CountryLabel.Name = "Participant_CountryLabel"
        Participant_CountryLabel.Size = New System.Drawing.Size(132, 17)
        Participant_CountryLabel.TabIndex = 24
        Participant_CountryLabel.Text = "Participant Country:"
        '
        'Participant_PhoneLabel
        '
        Participant_PhoneLabel.AutoSize = True
        Participant_PhoneLabel.Location = New System.Drawing.Point(27, 241)
        Participant_PhoneLabel.Name = "Participant_PhoneLabel"
        Participant_PhoneLabel.Size = New System.Drawing.Size(124, 17)
        Participant_PhoneLabel.TabIndex = 28
        Participant_PhoneLabel.Text = "Participant Phone:"
        '
        'Participant_EmailLabel
        '
        Participant_EmailLabel.AutoSize = True
        Participant_EmailLabel.Location = New System.Drawing.Point(276, 247)
        Participant_EmailLabel.Name = "Participant_EmailLabel"
        Participant_EmailLabel.Size = New System.Drawing.Size(117, 17)
        Participant_EmailLabel.TabIndex = 30
        Participant_EmailLabel.Text = "Participant Email:"
        '
        'Participant_DOBLabel
        '
        Participant_DOBLabel.AutoSize = True
        Participant_DOBLabel.Location = New System.Drawing.Point(825, 122)
        Participant_DOBLabel.Name = "Participant_DOBLabel"
        Participant_DOBLabel.Size = New System.Drawing.Size(113, 17)
        Participant_DOBLabel.TabIndex = 40
        Participant_DOBLabel.Text = "Participant DOB:"
        '
        'Participant_Date_HiredLabel
        '
        Participant_Date_HiredLabel.AutoSize = True
        Participant_Date_HiredLabel.Location = New System.Drawing.Point(834, 149)
        Participant_Date_HiredLabel.Name = "Participant_Date_HiredLabel"
        Participant_Date_HiredLabel.Size = New System.Drawing.Size(151, 17)
        Participant_Date_HiredLabel.TabIndex = 44
        Participant_Date_HiredLabel.Text = "Participant Date Hired:"
        '
        'Participant_DODLabel
        '
        Participant_DODLabel.AutoSize = True
        Participant_DODLabel.Location = New System.Drawing.Point(837, 179)
        Participant_DODLabel.Name = "Participant_DODLabel"
        Participant_DODLabel.Size = New System.Drawing.Size(114, 17)
        Participant_DODLabel.TabIndex = 46
        Participant_DODLabel.Text = "Participant DOD:"
        '
        'Participant_Termination_DateLabel
        '
        Participant_Termination_DateLabel.AutoSize = True
        Participant_Termination_DateLabel.Location = New System.Drawing.Point(842, 217)
        Participant_Termination_DateLabel.Name = "Participant_Termination_DateLabel"
        Participant_Termination_DateLabel.Size = New System.Drawing.Size(192, 17)
        Participant_Termination_DateLabel.TabIndex = 48
        Participant_Termination_DateLabel.Text = "Participant Termination Date:"
        '
        'Participant_Rehire_DateLabel
        '
        Participant_Rehire_DateLabel.AutoSize = True
        Participant_Rehire_DateLabel.Location = New System.Drawing.Point(834, 250)
        Participant_Rehire_DateLabel.Name = "Participant_Rehire_DateLabel"
        Participant_Rehire_DateLabel.Size = New System.Drawing.Size(159, 17)
        Participant_Rehire_DateLabel.TabIndex = 50
        Participant_Rehire_DateLabel.Text = "Participant Rehire Date:"
        '
        'Participant_Date_Last_ModifiedLabel
        '
        Participant_Date_Last_ModifiedLabel.AutoSize = True
        Participant_Date_Last_ModifiedLabel.Location = New System.Drawing.Point(822, 281)
        Participant_Date_Last_ModifiedLabel.Name = "Participant_Date_Last_ModifiedLabel"
        Participant_Date_Last_ModifiedLabel.Size = New System.Drawing.Size(201, 17)
        Participant_Date_Last_ModifiedLabel.TabIndex = 52
        Participant_Date_Last_ModifiedLabel.Text = "Participant Date Last Modified:"
        '
        'Participant_Base_EarningLabel
        '
        Participant_Base_EarningLabel.AutoSize = True
        Participant_Base_EarningLabel.Location = New System.Drawing.Point(18, 24)
        Participant_Base_EarningLabel.Name = "Participant_Base_EarningLabel"
        Participant_Base_EarningLabel.Size = New System.Drawing.Size(168, 17)
        Participant_Base_EarningLabel.TabIndex = 0
        Participant_Base_EarningLabel.Text = "Participant Base Earning:"
        '
        'Participant_Base_Effective_DateLabel
        '
        Participant_Base_Effective_DateLabel.AutoSize = True
        Participant_Base_Effective_DateLabel.Location = New System.Drawing.Point(21, 53)
        Participant_Base_Effective_DateLabel.Name = "Participant_Base_Effective_DateLabel"
        Participant_Base_Effective_DateLabel.Size = New System.Drawing.Size(207, 17)
        Participant_Base_Effective_DateLabel.TabIndex = 2
        Participant_Base_Effective_DateLabel.Text = "Participant Base Effective Date:"
        '
        'Participant_First_Contribution_DateLabel
        '
        Participant_First_Contribution_DateLabel.AutoSize = True
        Participant_First_Contribution_DateLabel.Location = New System.Drawing.Point(24, 88)
        Participant_First_Contribution_DateLabel.Name = "Participant_First_Contribution_DateLabel"
        Participant_First_Contribution_DateLabel.Size = New System.Drawing.Size(224, 17)
        Participant_First_Contribution_DateLabel.TabIndex = 4
        Participant_First_Contribution_DateLabel.Text = "Participant First Contribution Date:"
        '
        'Participant_Last_Contribution_DateLabel
        '
        Participant_Last_Contribution_DateLabel.AutoSize = True
        Participant_Last_Contribution_DateLabel.Location = New System.Drawing.Point(26, 117)
        Participant_Last_Contribution_DateLabel.Name = "Participant_Last_Contribution_DateLabel"
        Participant_Last_Contribution_DateLabel.Size = New System.Drawing.Size(224, 17)
        Participant_Last_Contribution_DateLabel.TabIndex = 6
        Participant_Last_Contribution_DateLabel.Text = "Participant Last Contribution Date:"
        '
        'ITDContributionLabel
        '
        ITDContributionLabel.AutoSize = True
        ITDContributionLabel.Location = New System.Drawing.Point(29, 144)
        ITDContributionLabel.Name = "ITDContributionLabel"
        ITDContributionLabel.Size = New System.Drawing.Size(110, 17)
        ITDContributionLabel.TabIndex = 8
        ITDContributionLabel.Text = "ITDContribution:"
        '
        'Participant_ITD_Pension_ContributionLabel
        '
        Participant_ITD_Pension_ContributionLabel.AutoSize = True
        Participant_ITD_Pension_ContributionLabel.Location = New System.Drawing.Point(29, 169)
        Participant_ITD_Pension_ContributionLabel.Name = "Participant_ITD_Pension_ContributionLabel"
        Participant_ITD_Pension_ContributionLabel.Size = New System.Drawing.Size(240, 17)
        Participant_ITD_Pension_ContributionLabel.TabIndex = 10
        Participant_ITD_Pension_ContributionLabel.Text = "Participant ITD Pension Contribution:"
        '
        'Participant_ITD_Insurance_DeductionLabel
        '
        Participant_ITD_Insurance_DeductionLabel.AutoSize = True
        Participant_ITD_Insurance_DeductionLabel.Location = New System.Drawing.Point(24, 196)
        Participant_ITD_Insurance_DeductionLabel.Name = "Participant_ITD_Insurance_DeductionLabel"
        Participant_ITD_Insurance_DeductionLabel.Size = New System.Drawing.Size(239, 17)
        Participant_ITD_Insurance_DeductionLabel.TabIndex = 12
        Participant_ITD_Insurance_DeductionLabel.Text = "Participant ITD Insurance Deduction:"
        '
        'Participant_Pension_SuspensionLabel
        '
        Participant_Pension_SuspensionLabel.AutoSize = True
        Participant_Pension_SuspensionLabel.Location = New System.Drawing.Point(30, 226)
        Participant_Pension_SuspensionLabel.Name = "Participant_Pension_SuspensionLabel"
        Participant_Pension_SuspensionLabel.Size = New System.Drawing.Size(212, 17)
        Participant_Pension_SuspensionLabel.TabIndex = 14
        Participant_Pension_SuspensionLabel.Text = "Participant Pension Suspension:"
        '
        'Participant_Pension_ReinstatementLabel
        '
        Participant_Pension_ReinstatementLabel.AutoSize = True
        Participant_Pension_ReinstatementLabel.Location = New System.Drawing.Point(40, 258)
        Participant_Pension_ReinstatementLabel.Name = "Participant_Pension_ReinstatementLabel"
        Participant_Pension_ReinstatementLabel.Size = New System.Drawing.Size(229, 17)
        Participant_Pension_ReinstatementLabel.TabIndex = 16
        Participant_Pension_ReinstatementLabel.Text = "Participant Pension Reinstatement:"
        '
        'Participant_Participation_dateLabel
        '
        Participant_Participation_dateLabel.AutoSize = True
        Participant_Participation_dateLabel.Location = New System.Drawing.Point(433, 84)
        Participant_Participation_dateLabel.Name = "Participant_Participation_dateLabel"
        Participant_Participation_dateLabel.Size = New System.Drawing.Size(193, 17)
        Participant_Participation_dateLabel.TabIndex = 22
        Participant_Participation_dateLabel.Text = "Participant Participation date:"
        '
        'Participant_Retirement_DateLabel
        '
        Participant_Retirement_DateLabel.AutoSize = True
        Participant_Retirement_DateLabel.Location = New System.Drawing.Point(438, 118)
        Participant_Retirement_DateLabel.Name = "Participant_Retirement_DateLabel"
        Participant_Retirement_DateLabel.Size = New System.Drawing.Size(186, 17)
        Participant_Retirement_DateLabel.TabIndex = 24
        Participant_Retirement_DateLabel.Text = "Participant Retirement Date:"
        '
        'Participant_Lump_Sum_PaymentLabel
        '
        Participant_Lump_Sum_PaymentLabel.AutoSize = True
        Participant_Lump_Sum_PaymentLabel.Location = New System.Drawing.Point(436, 146)
        Participant_Lump_Sum_PaymentLabel.Name = "Participant_Lump_Sum_PaymentLabel"
        Participant_Lump_Sum_PaymentLabel.Size = New System.Drawing.Size(209, 17)
        Participant_Lump_Sum_PaymentLabel.TabIndex = 26
        Participant_Lump_Sum_PaymentLabel.Text = "Participant Lump Sum Payment:"
        '
        'Participant_Lump_Sum_Payment_FlagLabel
        '
        Participant_Lump_Sum_Payment_FlagLabel.AutoSize = True
        Participant_Lump_Sum_Payment_FlagLabel.Location = New System.Drawing.Point(443, 181)
        Participant_Lump_Sum_Payment_FlagLabel.Name = "Participant_Lump_Sum_Payment_FlagLabel"
        Participant_Lump_Sum_Payment_FlagLabel.Size = New System.Drawing.Size(240, 17)
        Participant_Lump_Sum_Payment_FlagLabel.TabIndex = 28
        Participant_Lump_Sum_Payment_FlagLabel.Text = "Participant Lump Sum Payment Flag:"
        '
        'FutureServiceCreditLabel
        '
        FutureServiceCreditLabel.AutoSize = True
        FutureServiceCreditLabel.Location = New System.Drawing.Point(791, 62)
        FutureServiceCreditLabel.Name = "FutureServiceCreditLabel"
        FutureServiceCreditLabel.Size = New System.Drawing.Size(145, 17)
        FutureServiceCreditLabel.TabIndex = 30
        FutureServiceCreditLabel.Text = "Future Service Credit:"
        '
        'YearsOfServiceLabel
        '
        YearsOfServiceLabel.AutoSize = True
        YearsOfServiceLabel.Location = New System.Drawing.Point(790, 42)
        YearsOfServiceLabel.Name = "YearsOfServiceLabel"
        YearsOfServiceLabel.Size = New System.Drawing.Size(119, 17)
        YearsOfServiceLabel.TabIndex = 32
        YearsOfServiceLabel.Text = "Years Of Service:"
        '
        'MonthsOfServiceLabel
        '
        MonthsOfServiceLabel.AutoSize = True
        MonthsOfServiceLabel.Location = New System.Drawing.Point(802, 86)
        MonthsOfServiceLabel.Name = "MonthsOfServiceLabel"
        MonthsOfServiceLabel.Size = New System.Drawing.Size(128, 17)
        MonthsOfServiceLabel.TabIndex = 34
        MonthsOfServiceLabel.Text = "Months Of Service:"
        '
        'TotalServiceCreditLabel
        '
        TotalServiceCreditLabel.AutoSize = True
        TotalServiceCreditLabel.Location = New System.Drawing.Point(802, 121)
        TotalServiceCreditLabel.Name = "TotalServiceCreditLabel"
        TotalServiceCreditLabel.Size = New System.Drawing.Size(136, 17)
        TotalServiceCreditLabel.TabIndex = 36
        TotalServiceCreditLabel.Text = "Total Service Credit:"
        '
        'Participant_Award_DateLabel
        '
        Participant_Award_DateLabel.AutoSize = True
        Participant_Award_DateLabel.Location = New System.Drawing.Point(1101, 58)
        Participant_Award_DateLabel.Name = "Participant_Award_DateLabel"
        Participant_Award_DateLabel.Size = New System.Drawing.Size(156, 17)
        Participant_Award_DateLabel.TabIndex = 38
        Participant_Award_DateLabel.Text = "Participant Award Date:"
        '
        'Participant_ITD_Benefits_PaidLabel
        '
        Participant_ITD_Benefits_PaidLabel.AutoSize = True
        Participant_ITD_Benefits_PaidLabel.Location = New System.Drawing.Point(1103, 87)
        Participant_ITD_Benefits_PaidLabel.Name = "Participant_ITD_Benefits_PaidLabel"
        Participant_ITD_Benefits_PaidLabel.Size = New System.Drawing.Size(192, 17)
        Participant_ITD_Benefits_PaidLabel.TabIndex = 40
        Participant_ITD_Benefits_PaidLabel.Text = "Participant ITD Benefits Paid:"
        '
        'Participant_Last_Check_DateLabel
        '
        Participant_Last_Check_DateLabel.AutoSize = True
        Participant_Last_Check_DateLabel.Location = New System.Drawing.Point(1107, 121)
        Participant_Last_Check_DateLabel.Name = "Participant_Last_Check_DateLabel"
        Participant_Last_Check_DateLabel.Size = New System.Drawing.Size(187, 17)
        Participant_Last_Check_DateLabel.TabIndex = 42
        Participant_Last_Check_DateLabel.Text = "Participant Last Check Date:"
        '
        'Participant_QDR_DateLabel
        '
        Participant_QDR_DateLabel.AutoSize = True
        Participant_QDR_DateLabel.Location = New System.Drawing.Point(1133, 192)
        Participant_QDR_DateLabel.Name = "Participant_QDR_DateLabel"
        Participant_QDR_DateLabel.Size = New System.Drawing.Size(148, 17)
        Participant_QDR_DateLabel.TabIndex = 44
        Participant_QDR_DateLabel.Text = "Participant QDR Date:"
        '
        'Participant_QDR_AmountLabel
        '
        Participant_QDR_AmountLabel.AutoSize = True
        Participant_QDR_AmountLabel.Location = New System.Drawing.Point(1133, 225)
        Participant_QDR_AmountLabel.Name = "Participant_QDR_AmountLabel"
        Participant_QDR_AmountLabel.Size = New System.Drawing.Size(166, 17)
        Participant_QDR_AmountLabel.TabIndex = 46
        Participant_QDR_AmountLabel.Text = "Participant QDR Amount:"
        '
        'Participant_QDR_FlagLabel
        '
        Participant_QDR_FlagLabel.AutoSize = True
        Participant_QDR_FlagLabel.Location = New System.Drawing.Point(1134, 255)
        Participant_QDR_FlagLabel.Name = "Participant_QDR_FlagLabel"
        Participant_QDR_FlagLabel.Size = New System.Drawing.Size(145, 17)
        Participant_QDR_FlagLabel.TabIndex = 48
        Participant_QDR_FlagLabel.Text = "Participant QDR Flag:"
        '
        'Participant_OptionLabel
        '
        Participant_OptionLabel.AutoSize = True
        Participant_OptionLabel.Location = New System.Drawing.Point(436, 14)
        Participant_OptionLabel.Name = "Participant_OptionLabel"
        Participant_OptionLabel.Size = New System.Drawing.Size(125, 17)
        Participant_OptionLabel.TabIndex = 49
        Participant_OptionLabel.Text = "Participant Option:"
        '
        'Participant_Pension_TypeLabel
        '
        Participant_Pension_TypeLabel.AutoSize = True
        Participant_Pension_TypeLabel.Location = New System.Drawing.Point(436, 47)
        Participant_Pension_TypeLabel.Name = "Participant_Pension_TypeLabel"
        Participant_Pension_TypeLabel.Size = New System.Drawing.Size(170, 17)
        Participant_Pension_TypeLabel.TabIndex = 50
        Participant_Pension_TypeLabel.Text = "Participant Pension Type:"
        '
        'Participant_Country_CodeLabel
        '
        Participant_Country_CodeLabel.AutoSize = True
        Participant_Country_CodeLabel.Location = New System.Drawing.Point(287, 212)
        Participant_Country_CodeLabel.Name = "Participant_Country_CodeLabel"
        Participant_Country_CodeLabel.Size = New System.Drawing.Size(169, 17)
        Participant_Country_CodeLabel.TabIndex = 53
        Participant_Country_CodeLabel.Text = "Participant Country Code:"
        '
        'Participant_FundLabel
        '
        Participant_FundLabel.AutoSize = True
        Participant_FundLabel.Location = New System.Drawing.Point(33, 29)
        Participant_FundLabel.Name = "Participant_FundLabel"
        Participant_FundLabel.Size = New System.Drawing.Size(115, 17)
        Participant_FundLabel.TabIndex = 54
        Participant_FundLabel.Text = "Participant Fund:"
        '
        'Participant_Zip_CodeLabel
        '
        Participant_Zip_CodeLabel.AutoSize = True
        Participant_Zip_CodeLabel.Location = New System.Drawing.Point(290, 182)
        Participant_Zip_CodeLabel.Name = "Participant_Zip_CodeLabel"
        Participant_Zip_CodeLabel.Size = New System.Drawing.Size(140, 17)
        Participant_Zip_CodeLabel.TabIndex = 55
        Participant_Zip_CodeLabel.Text = "Participant Zip Code:"
        '
        'Participant_OrganizationLabel
        '
        Participant_OrganizationLabel.AutoSize = True
        Participant_OrganizationLabel.Location = New System.Drawing.Point(493, 25)
        Participant_OrganizationLabel.Name = "Participant_OrganizationLabel"
        Participant_OrganizationLabel.Size = New System.Drawing.Size(164, 17)
        Participant_OrganizationLabel.TabIndex = 56
        Participant_OrganizationLabel.Text = "Participant Organization:"
        '
        'Participant_StatusLabel
        '
        Participant_StatusLabel.AutoSize = True
        Participant_StatusLabel.Location = New System.Drawing.Point(528, 112)
        Participant_StatusLabel.Name = "Participant_StatusLabel"
        Participant_StatusLabel.Size = New System.Drawing.Size(123, 17)
        Participant_StatusLabel.TabIndex = 57
        Participant_StatusLabel.Text = "Participant Status:"
        '
        'Participant_Martial_StatusLabel
        '
        Participant_Martial_StatusLabel.AutoSize = True
        Participant_Martial_StatusLabel.Location = New System.Drawing.Point(530, 149)
        Participant_Martial_StatusLabel.Name = "Participant_Martial_StatusLabel"
        Participant_Martial_StatusLabel.Size = New System.Drawing.Size(169, 17)
        Participant_Martial_StatusLabel.TabIndex = 58
        Participant_Martial_StatusLabel.Text = "Participant Martial Status:"
        '
        'Participant_OE_FlagLabel
        '
        Participant_OE_FlagLabel.AutoSize = True
        Participant_OE_FlagLabel.Location = New System.Drawing.Point(572, 193)
        Participant_OE_FlagLabel.Name = "Participant_OE_FlagLabel"
        Participant_OE_FlagLabel.Size = New System.Drawing.Size(134, 17)
        Participant_OE_FlagLabel.TabIndex = 59
        Participant_OE_FlagLabel.Text = "Participant OE Flag:"
        '
        'VestedLabel
        '
        VestedLabel.AutoSize = True
        VestedLabel.Location = New System.Drawing.Point(559, 227)
        VestedLabel.Name = "VestedLabel"
        VestedLabel.Size = New System.Drawing.Size(56, 17)
        VestedLabel.TabIndex = 60
        VestedLabel.Text = "Vested:"
        '
        'Participant_Pay_FrequencyLabel
        '
        Participant_Pay_FrequencyLabel.AutoSize = True
        Participant_Pay_FrequencyLabel.Location = New System.Drawing.Point(554, 261)
        Participant_Pay_FrequencyLabel.Name = "Participant_Pay_FrequencyLabel"
        Participant_Pay_FrequencyLabel.Size = New System.Drawing.Size(178, 17)
        Participant_Pay_FrequencyLabel.TabIndex = 61
        Participant_Pay_FrequencyLabel.Text = "Participant Pay Frequency:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(801, 27)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(49, 17)
        NameLabel.TabIndex = 62
        NameLabel.Text = "Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(NameLabel)
        Me.GroupBox1.Controls.Add(Me.Name)
        Me.GroupBox1.Controls.Add(Participant_Pay_FrequencyLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_Pay_Frequency)
        Me.GroupBox1.Controls.Add(VestedLabel)
        Me.GroupBox1.Controls.Add(Me.Vested)
        Me.GroupBox1.Controls.Add(Participant_OE_FlagLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_OE_Flag)
        Me.GroupBox1.Controls.Add(Participant_Martial_StatusLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_Martial_Status)
        Me.GroupBox1.Controls.Add(Participant_StatusLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_Status)
        Me.GroupBox1.Controls.Add(Participant_OrganizationLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_Organization)
        Me.GroupBox1.Controls.Add(Participant_Zip_CodeLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_Zip_Code)
        Me.GroupBox1.Controls.Add(Participant_FundLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_Fund)
        Me.GroupBox1.Controls.Add(Participant_Country_CodeLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_Country_Code)
        Me.GroupBox1.Controls.Add(Participant_Date_Last_ModifiedLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_Date_Last_ModifiedDate)
        Me.GroupBox1.Controls.Add(Participant_Rehire_DateLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_Rehire_DateDate)
        Me.GroupBox1.Controls.Add(Participant_Termination_DateLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_Termination_DateDate)
        Me.GroupBox1.Controls.Add(Participant_DODLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_DODDate)
        Me.GroupBox1.Controls.Add(Participant_Date_HiredLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_Date_HiredDate)
        Me.GroupBox1.Controls.Add(Participant_DOBLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_DOBDate)
        Me.GroupBox1.Controls.Add(Participant_EmailLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_Email)
        Me.GroupBox1.Controls.Add(Participant_PhoneLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_Phone)
        Me.GroupBox1.Controls.Add(Participant_CountryLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_Country)
        Me.GroupBox1.Controls.Add(Participant_State_CodeLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_State_Code)
        Me.GroupBox1.Controls.Add(Participant_CityLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_City)
        Me.GroupBox1.Controls.Add(Participant_Address2Label)
        Me.GroupBox1.Controls.Add(Me.Participant_Address2)
        Me.GroupBox1.Controls.Add(Participant_Address1Label)
        Me.GroupBox1.Controls.Add(Me.Participant_Address1)
        Me.GroupBox1.Controls.Add(Participant_LastNameLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_LastName)
        Me.GroupBox1.Controls.Add(Participant_MInitialLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_MInitial)
        Me.GroupBox1.Controls.Add(Participant_FirstNameLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_FirstName)
        Me.GroupBox1.Controls.Add(Participant_SSNLabel)
        Me.GroupBox1.Controls.Add(Me.Participant_SSN)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1260, 321)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Name
        '
        Me.Name.FormattingEnabled = True
        Me.Name.Location = New System.Drawing.Point(856, 24)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(121, 24)
        Me.Name.TabIndex = 63
        '
        'Participant_Pay_Frequency
        '
        Me.Participant_Pay_Frequency.FormattingEnabled = True
        Me.Participant_Pay_Frequency.Location = New System.Drawing.Point(738, 258)
        Me.Participant_Pay_Frequency.Name = "Participant_Pay_Frequency"
        Me.Participant_Pay_Frequency.Size = New System.Drawing.Size(121, 24)
        Me.Participant_Pay_Frequency.TabIndex = 62
        '
        'Vested
        '
        Me.Vested.FormattingEnabled = True
        Me.Vested.Location = New System.Drawing.Point(621, 224)
        Me.Vested.Name = "Vested"
        Me.Vested.Size = New System.Drawing.Size(121, 24)
        Me.Vested.TabIndex = 61
        '
        'Participant_OE_Flag
        '
        Me.Participant_OE_Flag.FormattingEnabled = True
        Me.Participant_OE_Flag.Location = New System.Drawing.Point(712, 190)
        Me.Participant_OE_Flag.Name = "Participant_OE_Flag"
        Me.Participant_OE_Flag.Size = New System.Drawing.Size(121, 24)
        Me.Participant_OE_Flag.TabIndex = 60
        '
        'Participant_Martial_Status
        '
        Me.Participant_Martial_Status.FormattingEnabled = True
        Me.Participant_Martial_Status.Location = New System.Drawing.Point(705, 146)
        Me.Participant_Martial_Status.Name = "Participant_Martial_Status"
        Me.Participant_Martial_Status.Size = New System.Drawing.Size(121, 24)
        Me.Participant_Martial_Status.TabIndex = 59
        '
        'Participant_Status
        '
        Me.Participant_Status.FormattingEnabled = True
        Me.Participant_Status.Location = New System.Drawing.Point(657, 109)
        Me.Participant_Status.Name = "Participant_Status"
        Me.Participant_Status.Size = New System.Drawing.Size(121, 24)
        Me.Participant_Status.TabIndex = 58
        '
        'Participant_Organization
        '
        Me.Participant_Organization.FormattingEnabled = True
        Me.Participant_Organization.Location = New System.Drawing.Point(663, 22)
        Me.Participant_Organization.Name = "Participant_Organization"
        Me.Participant_Organization.Size = New System.Drawing.Size(121, 24)
        Me.Participant_Organization.TabIndex = 57
        '
        'Participant_Zip_Code
        '
        Me.Participant_Zip_Code.FormattingEnabled = True
        Me.Participant_Zip_Code.Location = New System.Drawing.Point(436, 179)
        Me.Participant_Zip_Code.Name = "Participant_Zip_Code"
        Me.Participant_Zip_Code.Size = New System.Drawing.Size(121, 24)
        Me.Participant_Zip_Code.TabIndex = 56
        '
        'Participant_Fund
        '
        Me.Participant_Fund.FormattingEnabled = True
        Me.Participant_Fund.Location = New System.Drawing.Point(154, 26)
        Me.Participant_Fund.Name = "Participant_Fund"
        Me.Participant_Fund.Size = New System.Drawing.Size(121, 24)
        Me.Participant_Fund.TabIndex = 55
        '
        'Participant_Country_Code
        '
        Me.Participant_Country_Code.FormattingEnabled = True
        Me.Participant_Country_Code.Location = New System.Drawing.Point(462, 209)
        Me.Participant_Country_Code.Name = "Participant_Country_Code"
        Me.Participant_Country_Code.Size = New System.Drawing.Size(37, 24)
        Me.Participant_Country_Code.TabIndex = 54
        '
        'Participant_Date_Last_ModifiedDate
        '
        Me.Participant_Date_Last_ModifiedDate.Location = New System.Drawing.Point(1029, 277)
        Me.Participant_Date_Last_ModifiedDate.Name = "Participant_Date_Last_ModifiedDate"
        Me.Participant_Date_Last_ModifiedDate.Size = New System.Drawing.Size(200, 22)
        Me.Participant_Date_Last_ModifiedDate.TabIndex = 53
        '
        'Participant_Rehire_DateDate
        '
        Me.Participant_Rehire_DateDate.Location = New System.Drawing.Point(999, 246)
        Me.Participant_Rehire_DateDate.Name = "Participant_Rehire_DateDate"
        Me.Participant_Rehire_DateDate.Size = New System.Drawing.Size(200, 22)
        Me.Participant_Rehire_DateDate.TabIndex = 51
        '
        'Participant_Termination_DateDate
        '
        Me.Participant_Termination_DateDate.Location = New System.Drawing.Point(1040, 213)
        Me.Participant_Termination_DateDate.Name = "Participant_Termination_DateDate"
        Me.Participant_Termination_DateDate.Size = New System.Drawing.Size(200, 22)
        Me.Participant_Termination_DateDate.TabIndex = 49
        '
        'Participant_DODDate
        '
        Me.Participant_DODDate.Location = New System.Drawing.Point(957, 175)
        Me.Participant_DODDate.Name = "Participant_DODDate"
        Me.Participant_DODDate.Size = New System.Drawing.Size(200, 22)
        Me.Participant_DODDate.TabIndex = 47
        '
        'Participant_Date_HiredDate
        '
        Me.Participant_Date_HiredDate.Location = New System.Drawing.Point(991, 145)
        Me.Participant_Date_HiredDate.Name = "Participant_Date_HiredDate"
        Me.Participant_Date_HiredDate.Size = New System.Drawing.Size(200, 22)
        Me.Participant_Date_HiredDate.TabIndex = 45
        '
        'Participant_DOBDate
        '
        Me.Participant_DOBDate.Location = New System.Drawing.Point(944, 118)
        Me.Participant_DOBDate.Name = "Participant_DOBDate"
        Me.Participant_DOBDate.Size = New System.Drawing.Size(170, 22)
        Me.Participant_DOBDate.TabIndex = 41
        '
        'Participant_Email
        '
        Me.Participant_Email.Location = New System.Drawing.Point(399, 244)
        Me.Participant_Email.Name = "Participant_Email"
        Me.Participant_Email.Size = New System.Drawing.Size(100, 22)
        Me.Participant_Email.TabIndex = 31
        '
        'Participant_Phone
        '
        Me.Participant_Phone.Location = New System.Drawing.Point(157, 238)
        Me.Participant_Phone.Name = "Participant_Phone"
        Me.Participant_Phone.Size = New System.Drawing.Size(80, 22)
        Me.Participant_Phone.TabIndex = 29
        '
        'Participant_Country
        '
        Me.Participant_Country.Location = New System.Drawing.Point(175, 203)
        Me.Participant_Country.Name = "Participant_Country"
        Me.Participant_Country.Size = New System.Drawing.Size(100, 22)
        Me.Participant_Country.TabIndex = 25
        '
        'Participant_State_Code
        '
        Me.Participant_State_Code.Location = New System.Drawing.Point(407, 155)
        Me.Participant_State_Code.Name = "Participant_State_Code"
        Me.Participant_State_Code.Size = New System.Drawing.Size(16, 22)
        Me.Participant_State_Code.TabIndex = 21
        '
        'Participant_City
        '
        Me.Participant_City.Location = New System.Drawing.Point(139, 150)
        Me.Participant_City.Name = "Participant_City"
        Me.Participant_City.Size = New System.Drawing.Size(100, 22)
        Me.Participant_City.TabIndex = 19
        '
        'Participant_Address2
        '
        Me.Participant_Address2.Location = New System.Drawing.Point(174, 120)
        Me.Participant_Address2.Name = "Participant_Address2"
        Me.Participant_Address2.Size = New System.Drawing.Size(100, 22)
        Me.Participant_Address2.TabIndex = 17
        '
        'Participant_Address1
        '
        Me.Participant_Address1.Location = New System.Drawing.Point(168, 85)
        Me.Participant_Address1.Name = "Participant_Address1"
        Me.Participant_Address1.Size = New System.Drawing.Size(100, 22)
        Me.Participant_Address1.TabIndex = 15
        '
        'Participant_LastName
        '
        Me.Participant_LastName.Location = New System.Drawing.Point(625, 61)
        Me.Participant_LastName.Name = "Participant_LastName"
        Me.Participant_LastName.Size = New System.Drawing.Size(100, 22)
        Me.Participant_LastName.TabIndex = 13
        '
        'Participant_MInitial
        '
        Me.Participant_MInitial.Location = New System.Drawing.Point(421, 57)
        Me.Participant_MInitial.Name = "Participant_MInitial"
        Me.Participant_MInitial.Size = New System.Drawing.Size(30, 22)
        Me.Participant_MInitial.TabIndex = 11
        '
        'Participant_FirstName
        '
        Me.Participant_FirstName.Location = New System.Drawing.Point(175, 53)
        Me.Participant_FirstName.Name = "Participant_FirstName"
        Me.Participant_FirstName.Size = New System.Drawing.Size(100, 22)
        Me.Participant_FirstName.TabIndex = 9
        '
        'Participant_SSN
        '
        Me.Participant_SSN.Location = New System.Drawing.Point(376, 28)
        Me.Participant_SSN.Name = "Participant_SSN"
        Me.Participant_SSN.Size = New System.Drawing.Size(100, 22)
        Me.Participant_SSN.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Participant_Pension_TypeLabel)
        Me.GroupBox2.Controls.Add(Me.Participant_Pension_Type)
        Me.GroupBox2.Controls.Add(Participant_OptionLabel)
        Me.GroupBox2.Controls.Add(Me.Participant_Option)
        Me.GroupBox2.Controls.Add(Participant_QDR_FlagLabel)
        Me.GroupBox2.Controls.Add(Me.Participant_QDR_Flag)
        Me.GroupBox2.Controls.Add(Participant_QDR_AmountLabel)
        Me.GroupBox2.Controls.Add(Me.Participant_QDR_Amount)
        Me.GroupBox2.Controls.Add(Participant_QDR_DateLabel)
        Me.GroupBox2.Controls.Add(Me.Participant_QDR_Date)
        Me.GroupBox2.Controls.Add(Participant_Last_Check_DateLabel)
        Me.GroupBox2.Controls.Add(Me.Participant_Last_Check_Date)
        Me.GroupBox2.Controls.Add(Participant_ITD_Benefits_PaidLabel)
        Me.GroupBox2.Controls.Add(Me.Participant_ITD_Benefits_Paid)
        Me.GroupBox2.Controls.Add(Participant_Award_DateLabel)
        Me.GroupBox2.Controls.Add(Me.Participant_Award_Date)
        Me.GroupBox2.Controls.Add(TotalServiceCreditLabel)
        Me.GroupBox2.Controls.Add(Me.TotalServiceCredit)
        Me.GroupBox2.Controls.Add(MonthsOfServiceLabel)
        Me.GroupBox2.Controls.Add(Me.MonthsOfService)
        Me.GroupBox2.Controls.Add(YearsOfServiceLabel)
        Me.GroupBox2.Controls.Add(Me.YearsOfService)
        Me.GroupBox2.Controls.Add(FutureServiceCreditLabel)
        Me.GroupBox2.Controls.Add(Me.FutureServiceCredit)
        Me.GroupBox2.Controls.Add(Participant_Lump_Sum_Payment_FlagLabel)
        Me.GroupBox2.Controls.Add(Me.Participant_Lump_Sum_Payment_Flag)
        Me.GroupBox2.Controls.Add(Participant_Lump_Sum_PaymentLabel)
        Me.GroupBox2.Controls.Add(Me.Participant_Lump_Sum_Payment)
        Me.GroupBox2.Controls.Add(Participant_Retirement_DateLabel)
        Me.GroupBox2.Controls.Add(Me.Participant_Retirement_Date)
        Me.GroupBox2.Controls.Add(Participant_Participation_dateLabel)
        Me.GroupBox2.Controls.Add(Me.Participant_Participation_date)
        Me.GroupBox2.Controls.Add(Participant_Pension_ReinstatementLabel)
        Me.GroupBox2.Controls.Add(Me.Participant_Pension_Reinstatement)
        Me.GroupBox2.Controls.Add(Participant_Pension_SuspensionLabel)
        Me.GroupBox2.Controls.Add(Me.Participant_Pension_Suspension)
        Me.GroupBox2.Controls.Add(Participant_ITD_Insurance_DeductionLabel)
        Me.GroupBox2.Controls.Add(Me.Participant_ITD_Insurance_Deduction)
        Me.GroupBox2.Controls.Add(Participant_ITD_Pension_ContributionLabel)
        Me.GroupBox2.Controls.Add(Me.Participant_ITD_Pension_Contribution)
        Me.GroupBox2.Controls.Add(ITDContributionLabel)
        Me.GroupBox2.Controls.Add(Me.ITDContribution)
        Me.GroupBox2.Controls.Add(Participant_Last_Contribution_DateLabel)
        Me.GroupBox2.Controls.Add(Me.Participant_Last_Contribution_Date)
        Me.GroupBox2.Controls.Add(Participant_First_Contribution_DateLabel)
        Me.GroupBox2.Controls.Add(Me.Participant_First_Contribution_Date)
        Me.GroupBox2.Controls.Add(Participant_Base_Effective_DateLabel)
        Me.GroupBox2.Controls.Add(Me.Participant_Base_Effective_Date)
        Me.GroupBox2.Controls.Add(Participant_Base_EarningLabel)
        Me.GroupBox2.Controls.Add(Me.Participant_Base_Earning)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 390)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1520, 298)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Participant_Pension_Type
        '
        Me.Participant_Pension_Type.FormattingEnabled = True
        Me.Participant_Pension_Type.Location = New System.Drawing.Point(612, 44)
        Me.Participant_Pension_Type.Name = "Participant_Pension_Type"
        Me.Participant_Pension_Type.Size = New System.Drawing.Size(121, 24)
        Me.Participant_Pension_Type.TabIndex = 51
        '
        'Participant_Option
        '
        Me.Participant_Option.FormattingEnabled = True
        Me.Participant_Option.Location = New System.Drawing.Point(567, 11)
        Me.Participant_Option.Name = "Participant_Option"
        Me.Participant_Option.Size = New System.Drawing.Size(121, 24)
        Me.Participant_Option.TabIndex = 50
        '
        'Participant_QDR_Flag
        '
        Me.Participant_QDR_Flag.FormattingEnabled = True
        Me.Participant_QDR_Flag.Location = New System.Drawing.Point(1285, 252)
        Me.Participant_QDR_Flag.Name = "Participant_QDR_Flag"
        Me.Participant_QDR_Flag.Size = New System.Drawing.Size(121, 24)
        Me.Participant_QDR_Flag.TabIndex = 49
        '
        'Participant_QDR_Amount
        '
        Me.Participant_QDR_Amount.Location = New System.Drawing.Point(1305, 222)
        Me.Participant_QDR_Amount.Name = "Participant_QDR_Amount"
        Me.Participant_QDR_Amount.Size = New System.Drawing.Size(100, 22)
        Me.Participant_QDR_Amount.TabIndex = 47
        '
        'Participant_QDR_Date
        '
        Me.Participant_QDR_Date.Location = New System.Drawing.Point(1287, 188)
        Me.Participant_QDR_Date.Name = "Participant_QDR_Date"
        Me.Participant_QDR_Date.Size = New System.Drawing.Size(150, 22)
        Me.Participant_QDR_Date.TabIndex = 45
        '
        'Participant_Last_Check_Date
        '
        Me.Participant_Last_Check_Date.Location = New System.Drawing.Point(1300, 117)
        Me.Participant_Last_Check_Date.Name = "Participant_Last_Check_Date"
        Me.Participant_Last_Check_Date.Size = New System.Drawing.Size(137, 22)
        Me.Participant_Last_Check_Date.TabIndex = 43
        '
        'Participant_ITD_Benefits_Paid
        '
        Me.Participant_ITD_Benefits_Paid.Location = New System.Drawing.Point(1301, 84)
        Me.Participant_ITD_Benefits_Paid.Name = "Participant_ITD_Benefits_Paid"
        Me.Participant_ITD_Benefits_Paid.Size = New System.Drawing.Size(100, 22)
        Me.Participant_ITD_Benefits_Paid.TabIndex = 41
        '
        'Participant_Award_Date
        '
        Me.Participant_Award_Date.Location = New System.Drawing.Point(1263, 54)
        Me.Participant_Award_Date.Name = "Participant_Award_Date"
        Me.Participant_Award_Date.Size = New System.Drawing.Size(122, 22)
        Me.Participant_Award_Date.TabIndex = 39
        '
        'TotalServiceCredit
        '
        Me.TotalServiceCredit.Location = New System.Drawing.Point(944, 118)
        Me.TotalServiceCredit.Name = "TotalServiceCredit"
        Me.TotalServiceCredit.Size = New System.Drawing.Size(100, 22)
        Me.TotalServiceCredit.TabIndex = 37
        '
        'MonthsOfService
        '
        Me.MonthsOfService.Location = New System.Drawing.Point(936, 83)
        Me.MonthsOfService.Name = "MonthsOfService"
        Me.MonthsOfService.Size = New System.Drawing.Size(100, 22)
        Me.MonthsOfService.TabIndex = 35
        '
        'YearsOfService
        '
        Me.YearsOfService.Location = New System.Drawing.Point(915, 39)
        Me.YearsOfService.Name = "YearsOfService"
        Me.YearsOfService.Size = New System.Drawing.Size(100, 22)
        Me.YearsOfService.TabIndex = 33
        '
        'FutureServiceCredit
        '
        Me.FutureServiceCredit.Location = New System.Drawing.Point(942, 59)
        Me.FutureServiceCredit.Name = "FutureServiceCredit"
        Me.FutureServiceCredit.Size = New System.Drawing.Size(100, 22)
        Me.FutureServiceCredit.TabIndex = 31
        '
        'Participant_Lump_Sum_Payment_Flag
        '
        Me.Participant_Lump_Sum_Payment_Flag.Location = New System.Drawing.Point(689, 178)
        Me.Participant_Lump_Sum_Payment_Flag.Name = "Participant_Lump_Sum_Payment_Flag"
        Me.Participant_Lump_Sum_Payment_Flag.Size = New System.Drawing.Size(53, 22)
        Me.Participant_Lump_Sum_Payment_Flag.TabIndex = 29
        '
        'Participant_Lump_Sum_Payment
        '
        Me.Participant_Lump_Sum_Payment.Location = New System.Drawing.Point(651, 143)
        Me.Participant_Lump_Sum_Payment.Name = "Participant_Lump_Sum_Payment"
        Me.Participant_Lump_Sum_Payment.Size = New System.Drawing.Size(68, 22)
        Me.Participant_Lump_Sum_Payment.TabIndex = 27
        '
        'Participant_Retirement_Date
        '
        Me.Participant_Retirement_Date.Location = New System.Drawing.Point(630, 114)
        Me.Participant_Retirement_Date.Name = "Participant_Retirement_Date"
        Me.Participant_Retirement_Date.Size = New System.Drawing.Size(66, 22)
        Me.Participant_Retirement_Date.TabIndex = 25
        '
        'Participant_Participation_date
        '
        Me.Participant_Participation_date.Location = New System.Drawing.Point(632, 80)
        Me.Participant_Participation_date.Name = "Participant_Participation_date"
        Me.Participant_Participation_date.Size = New System.Drawing.Size(45, 22)
        Me.Participant_Participation_date.TabIndex = 23
        '
        'Participant_Pension_Reinstatement
        '
        Me.Participant_Pension_Reinstatement.Location = New System.Drawing.Point(275, 254)
        Me.Participant_Pension_Reinstatement.Name = "Participant_Pension_Reinstatement"
        Me.Participant_Pension_Reinstatement.Size = New System.Drawing.Size(112, 22)
        Me.Participant_Pension_Reinstatement.TabIndex = 17
        '
        'Participant_Pension_Suspension
        '
        Me.Participant_Pension_Suspension.Location = New System.Drawing.Point(248, 222)
        Me.Participant_Pension_Suspension.Name = "Participant_Pension_Suspension"
        Me.Participant_Pension_Suspension.Size = New System.Drawing.Size(139, 22)
        Me.Participant_Pension_Suspension.TabIndex = 15
        '
        'Participant_ITD_Insurance_Deduction
        '
        Me.Participant_ITD_Insurance_Deduction.Location = New System.Drawing.Point(269, 193)
        Me.Participant_ITD_Insurance_Deduction.Name = "Participant_ITD_Insurance_Deduction"
        Me.Participant_ITD_Insurance_Deduction.Size = New System.Drawing.Size(37, 22)
        Me.Participant_ITD_Insurance_Deduction.TabIndex = 13
        '
        'Participant_ITD_Pension_Contribution
        '
        Me.Participant_ITD_Pension_Contribution.Location = New System.Drawing.Point(275, 166)
        Me.Participant_ITD_Pension_Contribution.Name = "Participant_ITD_Pension_Contribution"
        Me.Participant_ITD_Pension_Contribution.Size = New System.Drawing.Size(31, 22)
        Me.Participant_ITD_Pension_Contribution.TabIndex = 11
        '
        'ITDContribution
        '
        Me.ITDContribution.Location = New System.Drawing.Point(145, 141)
        Me.ITDContribution.Name = "ITDContribution"
        Me.ITDContribution.Size = New System.Drawing.Size(100, 22)
        Me.ITDContribution.TabIndex = 9
        '
        'Participant_Last_Contribution_Date
        '
        Me.Participant_Last_Contribution_Date.Location = New System.Drawing.Point(256, 113)
        Me.Participant_Last_Contribution_Date.Name = "Participant_Last_Contribution_Date"
        Me.Participant_Last_Contribution_Date.Size = New System.Drawing.Size(78, 22)
        Me.Participant_Last_Contribution_Date.TabIndex = 7
        '
        'Participant_First_Contribution_Date
        '
        Me.Participant_First_Contribution_Date.Location = New System.Drawing.Point(254, 84)
        Me.Participant_First_Contribution_Date.Name = "Participant_First_Contribution_Date"
        Me.Participant_First_Contribution_Date.Size = New System.Drawing.Size(89, 22)
        Me.Participant_First_Contribution_Date.TabIndex = 5
        '
        'Participant_Base_Effective_Date
        '
        Me.Participant_Base_Effective_Date.Location = New System.Drawing.Point(234, 49)
        Me.Participant_Base_Effective_Date.Name = "Participant_Base_Effective_Date"
        Me.Participant_Base_Effective_Date.Size = New System.Drawing.Size(100, 22)
        Me.Participant_Base_Effective_Date.TabIndex = 3
        '
        'Participant_Base_Earning
        '
        Me.Participant_Base_Earning.Location = New System.Drawing.Point(192, 21)
        Me.Participant_Base_Earning.Name = "Participant_Base_Earning"
        Me.Participant_Base_Earning.Size = New System.Drawing.Size(100, 22)
        Me.Participant_Base_Earning.TabIndex = 1
        '
        'frmParticipantInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1531, 709)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)

        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Name As System.Windows.Forms.ComboBox
    Friend WithEvents Participant_Pay_Frequency As System.Windows.Forms.ComboBox
    Friend WithEvents Vested As System.Windows.Forms.ComboBox
    Friend WithEvents Participant_OE_Flag As System.Windows.Forms.ComboBox
    Friend WithEvents Participant_Martial_Status As System.Windows.Forms.ComboBox
    Friend WithEvents Participant_Status As System.Windows.Forms.ComboBox
    Friend WithEvents Participant_Organization As System.Windows.Forms.ComboBox
    Friend WithEvents Participant_Zip_Code As System.Windows.Forms.ComboBox
    Friend WithEvents Participant_Fund As System.Windows.Forms.ComboBox
    Friend WithEvents Participant_Country_Code As System.Windows.Forms.ComboBox
    Friend WithEvents Participant_Date_Last_ModifiedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Participant_Rehire_DateDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Participant_Termination_DateDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Participant_DODDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Participant_Date_HiredDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Participant_DOBDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Participant_Email As System.Windows.Forms.TextBox
    Friend WithEvents Participant_Phone As System.Windows.Forms.TextBox
    Friend WithEvents Participant_Country As System.Windows.Forms.TextBox
    Friend WithEvents Participant_State_Code As System.Windows.Forms.TextBox
    Friend WithEvents Participant_City As System.Windows.Forms.TextBox
    Friend WithEvents Participant_Address2 As System.Windows.Forms.TextBox
    Friend WithEvents Participant_Address1 As System.Windows.Forms.TextBox
    Friend WithEvents Participant_LastName As System.Windows.Forms.TextBox
    Friend WithEvents Participant_MInitial As System.Windows.Forms.TextBox
    Friend WithEvents Participant_FirstName As System.Windows.Forms.TextBox
    Friend WithEvents Participant_SSN As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Participant_Pension_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Participant_Option As System.Windows.Forms.ComboBox
    Friend WithEvents Participant_QDR_Flag As System.Windows.Forms.ComboBox
    Friend WithEvents Participant_QDR_Amount As System.Windows.Forms.TextBox
    Friend WithEvents Participant_QDR_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Participant_Last_Check_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Participant_ITD_Benefits_Paid As System.Windows.Forms.TextBox
    Friend WithEvents Participant_Award_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents TotalServiceCredit As System.Windows.Forms.TextBox
    Friend WithEvents MonthsOfService As System.Windows.Forms.TextBox
    Friend WithEvents YearsOfService As System.Windows.Forms.TextBox
    Friend WithEvents FutureServiceCredit As System.Windows.Forms.TextBox
    Friend WithEvents Participant_Lump_Sum_Payment_Flag As System.Windows.Forms.TextBox
    Friend WithEvents Participant_Lump_Sum_Payment As System.Windows.Forms.TextBox
    Friend WithEvents Participant_Retirement_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Participant_Participation_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Participant_Pension_Reinstatement As System.Windows.Forms.DateTimePicker
    Friend WithEvents Participant_Pension_Suspension As System.Windows.Forms.DateTimePicker
    Friend WithEvents Participant_ITD_Insurance_Deduction As System.Windows.Forms.TextBox
    Friend WithEvents Participant_ITD_Pension_Contribution As System.Windows.Forms.TextBox
    Friend WithEvents ITDContribution As System.Windows.Forms.TextBox
    Friend WithEvents Participant_Last_Contribution_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Participant_First_Contribution_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Participant_Base_Effective_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Participant_Base_Earning As System.Windows.Forms.TextBox
End Class
