
using DevExpress.Xpo;

using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace DXExample.Module {
    [DefaultClassOptions]
    public class DomainObject1 : BaseObject {
        public DomainObject1(Session session) : base(session) { }
        private string _property1;
        public string Property1 {
            get { return _property1; }
            set { SetPropertyValue("Property1", ref _property1, value); }
        }
        private string _property2;
        public string Property2 {
            get { return _property2; }
            set { SetPropertyValue("Property2", ref _property2, value); }
        }
        private string _property3;
        public string Property3 {
            get { return _property3; }
            set { SetPropertyValue("Property3", ref _property3, value); }
        }
        private string _property4;
        public string Property4 {
            get { return _property4; }
            set { SetPropertyValue("Property4", ref _property4, value); }
        }
        private string _property5;
        public string Property5 {
            get { return _property5; }
            set { SetPropertyValue("Property5", ref _property5, value); }
        }
    }
}
