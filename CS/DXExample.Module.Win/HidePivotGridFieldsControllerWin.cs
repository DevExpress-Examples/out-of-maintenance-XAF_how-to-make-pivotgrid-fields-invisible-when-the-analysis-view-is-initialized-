using DevExpress.ExpressApp.PivotChart.Win;

namespace DXExample.Module.Web {
    public class HidePivotGridFieldsControllerWeb : HidePivotGridFieldsControllerBase {
        public HidePivotGridFieldsControllerWeb() { }
        protected override void SetFieldBuider(DevExpress.ExpressApp.PivotChart.IAnalysisControl control) {
            ((AnalysisControlWin)control).FieldBuilder = new CustomPivotFieldBuilder(control);
        }
    }
}
