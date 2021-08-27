<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128592017/10.2.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1395)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to make PivotGrid fields invisible when the Analysis view is initialized


<p>Sometimes, when a business class has a lot of properties, it is not suitable to have all of them in the Filter Area. This example demonstrates how to place fields into the Field List popup window by default. To do this, the AreaIndex property of the generated fields is set to -1, which means that these fields do not belong to any area. This is done via a custom field builder - <strong>CustomPivotFieldBuilder</strong>. This class is used by XAF to generate PivotGrid fields. Generated fields are modified in the field builder's <strong>AddFieldCore</strong> method. In this example, a custom field builder is assigned to the analysis editor via its <strong>FieldBuilder</strong> property in the <strong>HidePivotGridFieldsControllerBase</strong> controller. This solution is platform-independent, i.e. the same code works for both WinForms and ASP.NET.</p>

<br/>


