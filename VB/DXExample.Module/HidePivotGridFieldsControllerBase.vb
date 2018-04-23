Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.PivotChart

Namespace DXExample.Module
	Public Class HidePivotGridFieldsControllerBase
		Inherits ViewController
		Public Sub New()
			TargetObjectType = GetType(IAnalysisInfo)
			TargetViewType = ViewType.DetailView
		End Sub
		Protected Overrides Overloads Sub OnActivated()
			MyBase.OnActivated()
			AddHandler View.ControlsCreated, AddressOf View_ControlsCreated
		End Sub
		Private Sub View_ControlsCreated(ByVal sender As Object, ByVal e As EventArgs)
			For Each editor As AnalysisEditorBase In (CType(View, DetailView)).GetItems(Of AnalysisEditorBase)()
				Dim supportFB As ISupportPivotGridFieldBuilder = TryCast(editor.Control, ISupportPivotGridFieldBuilder)
				If supportFB IsNot Nothing Then
					supportFB.FieldBuilder = New CustomPivotFieldBuilder(editor.Control)
				End If
			Next editor
		End Sub
	End Class
End Namespace
