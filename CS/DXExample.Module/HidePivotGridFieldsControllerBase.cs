using System;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.PivotChart;

namespace DXExample.Module {
    public class HidePivotGridFieldsControllerBase : ViewController {
        public HidePivotGridFieldsControllerBase() {
            TargetObjectType = typeof(IAnalysisInfo);
            TargetViewType = ViewType.DetailView;
        }
        protected override void OnActivated() {
            base.OnActivated();
            View.ControlsCreated += new EventHandler(View_ControlsCreated);
        }
        private void View_ControlsCreated(object sender, EventArgs e) {
            foreach(AnalysisEditorBase editor in ((DetailView)View).GetItems<AnalysisEditorBase>()){
                ISupportPivotGridFieldBuilder supportFB = editor.Control as ISupportPivotGridFieldBuilder;
                if (supportFB != null) {
                    supportFB.FieldBuilder = new CustomPivotFieldBuilder(editor.Control);
                }
            }
        }
    }
}
