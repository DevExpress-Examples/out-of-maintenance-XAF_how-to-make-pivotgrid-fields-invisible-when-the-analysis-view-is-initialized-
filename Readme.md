# How to make PivotGrid fields invisible when the Analysis view is initialized


<p>Sometimes, when a business class has a lot of properties, it is not suitable to have all of them in the Filter Area. This example demonstrates how to place fields into the Field List popup window by default. To do this, the AreaIndex property of the generated fields is set to -1, which means that these fields do not belong to any area. This is done via a custom field builder - <strong>CustomPivotFieldBuilder</strong>. This class is used by XAF to generate PivotGrid fields. Generated fields are modified in the field builder's <strong>AddFieldCore</strong> method. In this example, a custom field builder is assigned to the analysis editor via its <strong>FieldBuilder</strong> property in the <strong>HidePivotGridFieldsControllerBase</strong> controller. This solution is platform-independent, i.e. the same code works for both WinForms and ASP.NET.</p>

<br/>


