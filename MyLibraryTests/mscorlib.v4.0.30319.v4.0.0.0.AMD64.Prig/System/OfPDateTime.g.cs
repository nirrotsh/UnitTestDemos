
using System;
using System.ComponentModel;
using System.Linq;
using Urasandesu.Prig.Framework;
using Urasandesu.Prig.Framework.PilotStubberConfiguration;

namespace System.Prig
{
    public class OfPDateTime : PDateTimeBase, IPrigTypeIntroducer 
    {
        public virtual ImplForNowGet NowGet() 
        {
            return new ImplForNowGet();
        }

        static IndirectionStub ms_stubNowGet = NewStubNowGet();
        static IndirectionStub NewStubNowGet()
        {
            var stubsXml = @"<?xml version=""1.0"" encoding=""utf-8""?>
<stubs>
  <add name=""NowGet"" alias=""NowGet"">
    <RuntimeMethodInfo xmlns:i=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:x=""http://www.w3.org/2001/XMLSchema"" z:Id=""1"" z:FactoryType=""MemberInfoSerializationHolder"" z:Type=""System.Reflection.MemberInfoSerializationHolder"" z:Assembly=""0"" xmlns:z=""http://schemas.microsoft.com/2003/10/Serialization/"" xmlns=""http://schemas.datacontract.org/2004/07/System.Reflection"">
          <Name z:Id=""2"" z:Type=""System.String"" z:Assembly=""0"" xmlns="""">get_Now</Name>
          <AssemblyName z:Id=""3"" z:Type=""System.String"" z:Assembly=""0"" xmlns="""">mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</AssemblyName>
          <ClassName z:Id=""4"" z:Type=""System.String"" z:Assembly=""0"" xmlns="""">System.DateTime</ClassName>
          <Signature z:Id=""5"" z:Type=""System.String"" z:Assembly=""0"" xmlns="""">System.DateTime get_Now()</Signature>
          <Signature2 z:Id=""6"" z:Type=""System.String"" z:Assembly=""0"" xmlns="""">System.DateTime get_Now()</Signature2>
          <MemberType z:Id=""7"" z:Type=""System.Int32"" z:Assembly=""0"" xmlns="""">8</MemberType>
          <GenericArguments i:nil=""true"" xmlns="""" />
        </RuntimeMethodInfo>
  </add>
</stubs>";
            var section = new PrigSection();
            section.DeserializeStubs(stubsXml);
            return section.Stubs.First();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public class ImplForNowGet : TypedBehaviorPreparableImpl 
        {
            public ImplForNowGet()
                : base(ms_stubNowGet, new Type[] {  }, new Type[] {  })
            { }
        }


        public static Type Type
        {
            get { return ms_stubNowGet.GetDeclaringTypeInstance(new Type[] {  }); }
        }
    }
}
