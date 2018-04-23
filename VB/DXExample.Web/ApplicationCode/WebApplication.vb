Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Web

Namespace DXExample.Web
	Partial Public Class DXExampleAspNetApplication
		Inherits WebApplication
		Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
		Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule
		Private module3 As DXExample.Module.DXExampleModule
		Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule
		Private securitySimple1 As DevExpress.ExpressApp.Security.SecuritySimple
		Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
		Private authenticationActiveDirectory1 As DevExpress.ExpressApp.Security.AuthenticationActiveDirectory
		Private pivotChartAspNetModule1 As DevExpress.ExpressApp.PivotChart.Web.PivotChartAspNetModule
		Private pivotChartModuleBase1 As DevExpress.ExpressApp.PivotChart.PivotChartModuleBase
		Private module5 As DevExpress.ExpressApp.Validation.ValidationModule

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub DXExampleAspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
			If System.Diagnostics.Debugger.IsAttached Then
				e.Updater.Update()
				e.Handled = True
			Else
				Throw New InvalidOperationException("The application cannot connect to the specified database, because the latter doesn't exist or its version is older than that of the application." & Constants.vbCrLf & "The automatic update is disabled, because the application was started without debugging." & Constants.vbCrLf & "You should start the application under Visual Studio, or modify the " & "source code of the 'DatabaseVersionMismatch' event handler to enable automatic database update, " & "or manually create a database using the 'DBUpdater' tool.")
			End If
		End Sub

		Private Sub InitializeComponent()
			Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
			Me.module2 = New DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule()
			Me.module3 = New DXExample.Module.DXExampleModule()
			Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule()
			Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
			Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
			Me.securitySimple1 = New DevExpress.ExpressApp.Security.SecuritySimple()
			Me.authenticationActiveDirectory1 = New DevExpress.ExpressApp.Security.AuthenticationActiveDirectory()
			Me.pivotChartAspNetModule1 = New DevExpress.ExpressApp.PivotChart.Web.PivotChartAspNetModule()
			Me.pivotChartModuleBase1 = New DevExpress.ExpressApp.PivotChart.PivotChartModuleBase()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' module1
			' 
			Me.module1.AdditionalExportedTypes.Add(GetType(DevExpress.Xpo.XPObjectType))
			' 
			' module3
			' 
			Me.module3.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.Analysis))
			' 
			' module5
			' 
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResult))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResultItem))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RulePropertyValueProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleRequiredFieldProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleFromBoolPropertyProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleRangeProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleValueComparisonProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleStringComparisonProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleRegularExpressionProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleCriteriaProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleSearchObjectProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleObjectExistsProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleUniqueValueProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleIsReferencedProperties))
			Me.module5.AllowValidationDetailsAccess = True
			' 
			' securitySimple1
			' 
			Me.securitySimple1.Authentication = Me.authenticationActiveDirectory1
			Me.securitySimple1.IsGrantedForNonExistentPermission = False
			Me.securitySimple1.UserType = GetType(DevExpress.Persistent.BaseImpl.SimpleUser)
			' 
			' authenticationActiveDirectory1
			' 
			Me.authenticationActiveDirectory1.CreateUserAutomatically = True
			' 
			' pivotChartAspNetModule1
			' 
			Me.pivotChartAspNetModule1.Description = "Provides the capability to analyze data via the ASPxPivotGrid and XtraCharts cont" & "rols. Works with the Business Class Library's analysis-specific data types."
			Me.pivotChartAspNetModule1.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.SystemModule.SystemModule))
			Me.pivotChartAspNetModule1.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.PivotChart.PivotChartModuleBase))
			' 
			' pivotChartModuleBase1
			' 
			Me.pivotChartModuleBase1.ShowAdditionalNavigation = False
			' 
			' DXExampleAspNetApplication
			' 
			Me.ApplicationName = "DXExample"
			Me.Modules.Add(Me.module1)
			Me.Modules.Add(Me.module2)
			Me.Modules.Add(Me.module6)
			Me.Modules.Add(Me.module3)
			Me.Modules.Add(Me.module5)
			Me.Modules.Add(Me.securityModule1)
			Me.Modules.Add(Me.pivotChartModuleBase1)
			Me.Modules.Add(Me.pivotChartAspNetModule1)
			Me.Security = Me.securitySimple1
'			Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.DXExampleAspNetApplication_DatabaseVersionMismatch);
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub
	End Class
End Namespace
