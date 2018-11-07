Imports System

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.PivotChart

Namespace DXExample.Module
    Public Class HidePivotGridFieldsController
        Inherits ObjectViewController(Of DetailView, IAnalysisInfo)

        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            For Each editor As AnalysisEditorBase In View.GetItems(Of AnalysisEditorBase)()
                AddHandler editor.ControlCreated, AddressOf editor_ControlCreated
            Next editor
        End Sub
        Private Sub editor_ControlCreated(ByVal sender As Object, ByVal e As EventArgs)
            Dim supportFB As ISupportPivotGridFieldBuilder = TryCast(DirectCast(sender, AnalysisEditorBase).Control, ISupportPivotGridFieldBuilder)
            If supportFB IsNot Nothing Then
                supportFB.FieldBuilder = New CustomPivotFieldBuilder(DirectCast(supportFB, IAnalysisControl))
                supportFB.FieldBuilder.SetModel(Application.Model)
            End If
        End Sub
        Protected Overrides Sub OnDeactivated()
            MyBase.OnDeactivated()
            For Each editor As AnalysisEditorBase In View.GetItems(Of AnalysisEditorBase)()
                RemoveHandler editor.ControlCreated, AddressOf editor_ControlCreated
            Next editor
        End Sub
    End Class
End Namespace
