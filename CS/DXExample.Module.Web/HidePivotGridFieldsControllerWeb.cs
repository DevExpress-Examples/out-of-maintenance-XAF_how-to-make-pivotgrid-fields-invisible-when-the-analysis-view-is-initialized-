using DevExpress.ExpressApp.PivotChart.Web;

namespace DXExample.Module.Web {
    public class HidePivotGridFieldsControllerWeb : HidePivotGridFieldsControllerBase {
        public HidePivotGridFieldsControllerWeb() { }
        protected override void SetFieldBuider(DevExpress.ExpressApp.PivotChart.IAnalysisControl control) {
            ((AnalysisControlWeb)control).FieldBuilder = new CustomPivotFieldBuilder(control);
        }
    }
}
