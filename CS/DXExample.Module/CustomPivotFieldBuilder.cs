using DevExpress.ExpressApp.PivotChart;

namespace DXExample.Module {
    public class CustomPivotFieldBuilder : PivotGridFieldBuilder {
        public CustomPivotFieldBuilder(IAnalysisControl owner) : base(owner) { }
        protected override void AddFieldCore(string caption, string bindingPropertyName, DevExpress.ExpressApp.DC.IMemberInfo propertyDescriptor) {
            base.AddFieldCore(caption, bindingPropertyName, propertyDescriptor);
            Owner.Fields[bindingPropertyName].AreaIndex = -1;
        }
    }
}
