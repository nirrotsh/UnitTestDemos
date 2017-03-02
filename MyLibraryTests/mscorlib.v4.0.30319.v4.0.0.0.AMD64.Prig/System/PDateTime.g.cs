
using System;
using System.ComponentModel;
using System.Linq;
using Urasandesu.Prig.Framework;
using Urasandesu.Prig.Framework.PilotStubberConfiguration;

namespace System.Prig
{
    public class PDateTime : PDateTimeBase 
    {
        public static IndirectionBehaviors DefaultBehavior { get; internal set; }

        public static TypedBehaviorPreparable<Urasandesu.Prig.Delegates.IndirectionFunc<System.DateTime>> NowGet() 
        {
            return Stub<OfPDateTime>.Setup<Urasandesu.Prig.Delegates.IndirectionFunc<System.DateTime>>(_ => _.NowGet());
        }


        public static TypeBehaviorSetting ExcludeGeneric()
        {
            return Stub<OfPDateTime>.ExcludeGeneric(new TypeBehaviorSetting());
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public class TypeBehaviorSetting : BehaviorSetting
        {
            public override IndirectionBehaviors DefaultBehavior
            {
                set
                {
                    PDateTime.DefaultBehavior = value;
                    foreach (var preparable in Preparables)
                        preparable.Prepare(PDateTime.DefaultBehavior);
                }
            }
        }
    }
}
