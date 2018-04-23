Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp.PivotChart

Namespace DXExample.Module
	Public Class CustomPivotFieldBuilder
		Inherits PivotGridFieldBuilder
		Public Sub New(ByVal owner As IAnalysisControl)
			MyBase.New(owner)
		End Sub
		Protected Overrides Sub AddFieldCore(ByVal caption As String, ByVal bindingPropertyName As String, ByVal propertyDescriptor As DevExpress.ExpressApp.DC.IMemberInfo)
			MyBase.AddFieldCore(caption, bindingPropertyName, propertyDescriptor)
			Owner.Fields(bindingPropertyName).AreaIndex = -1
		End Sub
	End Class
End Namespace
