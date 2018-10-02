using System;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.PivotChart;

namespace DXExample.Module {
    public class HidePivotGridFieldsController : ObjectViewController<DetailView, IAnalysisInfo> {
        protected override void OnActivated() {
            base.OnActivated();
            foreach (AnalysisEditorBase editor in View.GetItems<AnalysisEditorBase>()) {
                editor.ControlCreated += editor_ControlCreated;
            }
        }
        void editor_ControlCreated(object sender, EventArgs e) {
            ISupportPivotGridFieldBuilder supportFB = ((AnalysisEditorBase)sender).Control as ISupportPivotGridFieldBuilder;
            if (supportFB != null) {
                supportFB.FieldBuilder = new CustomPivotFieldBuilder((IAnalysisControl)supportFB);
                supportFB.FieldBuilder.SetModel(Application.Model);
            }
        }
        protected override void OnDeactivated() {
            base.OnDeactivated();
            foreach (AnalysisEditorBase editor in View.GetItems<AnalysisEditorBase>()) {
                editor.ControlCreated -= editor_ControlCreated;
            }
        }
    }
}
