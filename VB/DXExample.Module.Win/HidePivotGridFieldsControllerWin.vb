Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp.PivotChart.Win

Namespace DXExample.Module.Web
	Public Class HidePivotGridFieldsControllerWeb
		Inherits HidePivotGridFieldsControllerBase
		Public Sub New()
		End Sub
		Protected Overrides Sub SetFieldBuider(ByVal control As DevExpress.ExpressApp.PivotChart.IAnalysisControl)
			CType(control, AnalysisControlWin).FieldBuilder = New CustomPivotFieldBuilder(control)
		End Sub
	End Class
End Namespace
