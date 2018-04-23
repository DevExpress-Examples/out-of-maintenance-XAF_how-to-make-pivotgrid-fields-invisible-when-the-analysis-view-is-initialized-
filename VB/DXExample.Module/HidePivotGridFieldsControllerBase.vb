Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.PivotChart

Namespace DXExample.Module
	Public MustInherit Class HidePivotGridFieldsControllerBase
		Inherits ViewController
		Public Sub New()
			TargetObjectType = GetType(IAnalysisInfo)
			TargetViewType = ViewType.DetailView
		End Sub
		Protected Overrides Sub OnActivated()
			MyBase.OnActivated()
			AddHandler View.ControlsCreated, AddressOf View_ControlsCreated
		End Sub
		Private Sub View_ControlsCreated(ByVal sender As Object, ByVal e As EventArgs)
			For Each editor As AnalysisEditorBase In (CType(View, DetailView)).GetItems(Of AnalysisEditorBase)()
				SetFieldBuider(editor.Control)
			Next editor
		End Sub
		Protected MustOverride Sub SetFieldBuider(ByVal control As IAnalysisControl)
	End Class
End Namespace
