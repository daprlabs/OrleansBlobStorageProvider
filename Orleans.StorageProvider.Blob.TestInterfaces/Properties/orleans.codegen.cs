//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace Orleans.StorageProvider.Blob.TestInterfaces
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;
    using System.Collections.Generic;
    using Orleans;
    using System.Reflection;
    using Orleans.Serialization;
    using Orleans.StorageProvider.Blob.TestInterfaces;
    using System.Collections;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class EmailFactory
    {
        

                        public static IEmail GetGrain(long primaryKey, string keyExt)
                        {
                            return Cast(GrainFactoryBase.MakeKeyExtendedGrainReferenceInternal(typeof(IEmail), 1472255540, primaryKey, keyExt));
                        }

                        public static IEmail GetGrain(long primaryKey, string keyExt, string grainClassNamePrefix)
                        {
                            return Cast(GrainFactoryBase.MakeKeyExtendedGrainReferenceInternal(typeof(IEmail), 1472255540, primaryKey, keyExt, grainClassNamePrefix));
                        }

                        public static IEmail GetGrain(Guid primaryKey, string keyExt)
                        {
                            return Cast(GrainFactoryBase.MakeKeyExtendedGrainReferenceInternal(typeof(IEmail), 1472255540, primaryKey, keyExt));
                        }

                        public static IEmail GetGrain(Guid primaryKey, string keyExt, string grainClassNamePrefix)
                        {
                            return Cast(GrainFactoryBase.MakeKeyExtendedGrainReferenceInternal(typeof(IEmail), 1472255540, primaryKey, keyExt,grainClassNamePrefix));
                        }

            public static IEmail Cast(IAddressable grainRef)
            {
                
                return EmailReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [Orleans.GrainReferenceAttribute("Orleans.StorageProvider.Blob.TestInterfaces.IEmail")]
        internal class EmailReference : Orleans.GrainReference, IEmail, Orleans.IAddressable
        {
            

            public static IEmail Cast(IAddressable grainRef)
            {
                
                return (IEmail) GrainReference.CastInternal(typeof(IEmail), (GrainReference gr) => { return new EmailReference(gr);}, grainRef, 1472255540);
            }

                protected override int InterfaceId { get { return 1472255540; } }

                public override bool IsCompatible(int interfaceId) { return interfaceId == this.InterfaceId; }

                protected override string InterfaceName { get { return "Orleans.StorageProvider.Blob.TestInterfaces.IEmail"; } }

                protected override string GetMethodName(int interfaceId, int methodId) { return EmailMethodInvoker.GetMethodName(interfaceId, methodId); }

            public async System.Threading.Tasks.Task<EmailProperties> GetProperties() 
            { 
                return await base.InvokeMethodAsync<EmailProperties>( -606142484, new object[]{}, TimeSpan.Zero);
            }
            
            
            protected internal EmailReference(GrainReference reference) : 
                    base(reference)
            {
            }
            
            public System.Threading.Tasks.Task<Orleans.StorageProvider.Blob.TestInterfaces.IPerson> Person
            {
                get
                {

                return base.InvokeMethodAsync<Orleans.StorageProvider.Blob.TestInterfaces.IPerson>(696601301, new object[] {}, TimeSpan.Zero , options: InvokeMethodOptions.ReadOnly);
                }
            }
            
            [Orleans.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                EmailReference input = ((EmailReference)(original));
                return ((EmailReference)(GrainReference.CopyGrainReference(input)));
            }
            
            [Orleans.SerializerMethodAttribute()]
            public static void _Serializer(object original, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                EmailReference input = ((EmailReference)(original));
                GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [Orleans.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return EmailReference.Cast(((Orleans.GrainReference)(GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public System.Threading.Tasks.Task SetPerson(Orleans.StorageProvider.Blob.TestInterfaces.IPerson person)
            {

                return base.InvokeMethodAsync<object>(-646214881, new object[] {person is GrainBase ? Orleans.StorageProvider.Blob.TestInterfaces.PersonFactory.Cast(person.AsReference()) : person}, TimeSpan.Zero );
            }
            
            public System.Threading.Tasks.Task Send()
            {

                return base.InvokeMethodAsync<object>(-470441258, new object[] {}, TimeSpan.Zero );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [Orleans.MethodInvokerAttribute("Orleans.StorageProvider.Blob.TestInterfaces.IEmail", 1472255540)]
    internal class EmailMethodInvoker : IGrainMethodInvoker
    {
        
        public int InterfaceId
        {
            get
            {
                return 1472255540;
            }
        }
        
        public async System.Threading.Tasks.Task<Object> Invoke(IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {
                if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1472255540:  // IEmail
                        switch (methodId)
                        {
                            case -646214881: 
                                await ((IEmail)grain).SetPerson((IPerson)arguments[0]);
                              return true;
                            case 696601301: 
                                return await ((IEmail)grain).Person;
                            case -470441258: 
                                await ((IEmail)grain).Send();
                              return true;
                            case -606142484: return ((IEmail)grain).GetProperties();
                                                        default: 
                                throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case 1472255540:  // IEmail
                    switch (methodId)
                    {
                        case -646214881:
                            return "SetPerson";
                    case 696601301:
                            return "get_Person";
                    case -470441258:
                            return "Send";
                    case -606142484:
                            return "GetProperties";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [System.SerializableAttribute()]
    public static class EmailExtensionMethods
    {
        
static public System.Threading.Tasks.Task<EmailProperties> GetProperties(this IEmail interfaceData) 
            { 
                EmailFactory.EmailReference gref = interfaceData as EmailFactory.EmailReference;
                 return gref.GetProperties();
            }
            
    }
    
    [Serializable()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class EmailProperties
    {
        

            public IPerson Person { get; set; }
            public Dictionary<string,object> AsDictionary()
            {  
                var retValue = new Dictionary<string,object>();
                retValue["Person"] = Person;
                return retValue;
            }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class PersonFactory
    {
        

                        public static IPerson GetGrain(long primaryKey)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IPerson), -1576500780, primaryKey));
                        }

                        public static IPerson GetGrain(long primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IPerson), -1576500780, primaryKey, grainClassNamePrefix));
                        }

                        public static IPerson GetGrain(Guid primaryKey)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IPerson), -1576500780, primaryKey));
                        }

                        public static IPerson GetGrain(Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IPerson), -1576500780, primaryKey, grainClassNamePrefix));
                        }

            public static IPerson Cast(IAddressable grainRef)
            {
                
                return PersonReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [Orleans.GrainReferenceAttribute("Orleans.StorageProvider.Blob.TestInterfaces.IPerson")]
        internal class PersonReference : Orleans.GrainReference, IPerson, Orleans.IAddressable
        {
            

            public static IPerson Cast(IAddressable grainRef)
            {
                
                return (IPerson) GrainReference.CastInternal(typeof(IPerson), (GrainReference gr) => { return new PersonReference(gr);}, grainRef, -1576500780);
            }

                protected override int InterfaceId { get { return -1576500780; } }

                public override bool IsCompatible(int interfaceId) { return interfaceId == this.InterfaceId; }

                protected override string InterfaceName { get { return "Orleans.StorageProvider.Blob.TestInterfaces.IPerson"; } }

                protected override string GetMethodName(int interfaceId, int methodId) { return PersonMethodInvoker.GetMethodName(interfaceId, methodId); }

            public async System.Threading.Tasks.Task<PersonProperties> GetProperties() 
            { 
                return await base.InvokeMethodAsync<PersonProperties>( -606142484, new object[]{}, TimeSpan.Zero);
            }
            
            
            protected internal PersonReference(GrainReference reference) : 
                    base(reference)
            {
            }
            
            public System.Threading.Tasks.Task<string> FirstName
            {
                get
                {

                return base.InvokeMethodAsync<System.String>(-1287040473, new object[] {}, TimeSpan.Zero , options: InvokeMethodOptions.ReadOnly);
                }
            }
            
            public System.Threading.Tasks.Task<string> LastName
            {
                get
                {

                return base.InvokeMethodAsync<System.String>(60938995, new object[] {}, TimeSpan.Zero , options: InvokeMethodOptions.ReadOnly);
                }
            }
            
            public System.Threading.Tasks.Task<int> Age
            {
                get
                {

                return base.InvokeMethodAsync<System.Int32>(-1663040007, new object[] {}, TimeSpan.Zero , options: InvokeMethodOptions.ReadOnly);
                }
            }
            
            public System.Threading.Tasks.Task<Orleans.StorageProvider.Blob.TestInterfaces.GenderType> Gender
            {
                get
                {

                return base.InvokeMethodAsync<Orleans.StorageProvider.Blob.TestInterfaces.GenderType>(871790933, new object[] {}, TimeSpan.Zero , options: InvokeMethodOptions.ReadOnly);
                }
            }
            
            [Orleans.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                PersonReference input = ((PersonReference)(original));
                return ((PersonReference)(GrainReference.CopyGrainReference(input)));
            }
            
            [Orleans.SerializerMethodAttribute()]
            public static void _Serializer(object original, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                PersonReference input = ((PersonReference)(original));
                GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [Orleans.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return PersonReference.Cast(((Orleans.GrainReference)(GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public System.Threading.Tasks.Task SetPersonalAttributes(Orleans.StorageProvider.Blob.TestInterfaces.PersonalAttributes person)
            {

                return base.InvokeMethodAsync<object>(-1862634097, new object[] {person}, TimeSpan.Zero );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [Orleans.MethodInvokerAttribute("Orleans.StorageProvider.Blob.TestInterfaces.IPerson", -1576500780)]
    internal class PersonMethodInvoker : IGrainMethodInvoker
    {
        
        public int InterfaceId
        {
            get
            {
                return -1576500780;
            }
        }
        
        public async System.Threading.Tasks.Task<Object> Invoke(IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {
                if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -1576500780:  // IPerson
                        switch (methodId)
                        {
                            case -1862634097: 
                                await ((IPerson)grain).SetPersonalAttributes((PersonalAttributes)arguments[0]);
                              return true;
                            case -1287040473: 
                                return await ((IPerson)grain).FirstName;
                            case 60938995: 
                                return await ((IPerson)grain).LastName;
                            case -1663040007: 
                                return await ((IPerson)grain).Age;
                            case 871790933: 
                                return await ((IPerson)grain).Gender;
                            case -606142484: return ((IPerson)grain).GetProperties();
                                                        default: 
                                throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case -1576500780:  // IPerson
                    switch (methodId)
                    {
                        case -1862634097:
                            return "SetPersonalAttributes";
                    case -1287040473:
                            return "get_FirstName";
                    case 60938995:
                            return "get_LastName";
                    case -1663040007:
                            return "get_Age";
                    case 871790933:
                            return "get_Gender";
                    case -606142484:
                            return "GetProperties";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [System.SerializableAttribute()]
    public static class PersonExtensionMethods
    {
        
static public System.Threading.Tasks.Task<PersonProperties> GetProperties(this IPerson interfaceData) 
            { 
                PersonFactory.PersonReference gref = interfaceData as PersonFactory.PersonReference;
                 return gref.GetProperties();
            }
            
    }
    
    [Serializable()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class PersonProperties
    {
        

            public String FirstName { get; set; }
            public String LastName { get; set; }
            public Int32 Age { get; set; }
            public GenderType Gender { get; set; }
            public Dictionary<string,object> AsDictionary()
            {  
                var retValue = new Dictionary<string,object>();
                retValue["FirstName"] = FirstName;
                retValue["LastName"] = LastName;
                retValue["Age"] = Age;
                retValue["Gender"] = Gender;
                return retValue;
            }
    }
    
    [Orleans.RegisterSerializerAttribute()]
    internal class Orleans_StorageProvider_Blob_TestInterfaces_PersonalAttributesSerialization
    {
        
        static Orleans_StorageProvider_Blob_TestInterfaces_PersonalAttributesSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            Orleans.StorageProvider.Blob.TestInterfaces.PersonalAttributes input = ((Orleans.StorageProvider.Blob.TestInterfaces.PersonalAttributes)(original));
            Orleans.StorageProvider.Blob.TestInterfaces.PersonalAttributes result = new Orleans.StorageProvider.Blob.TestInterfaces.PersonalAttributes();
            Orleans.Serialization.SerializationContext.Current.RecordObject(original, result);
            result.Age = input.Age;
            result.FirstName = input.FirstName;
            result.Gender = input.Gender;
            result.LastName = input.LastName;
            return result;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            Orleans.StorageProvider.Blob.TestInterfaces.PersonalAttributes input = ((Orleans.StorageProvider.Blob.TestInterfaces.PersonalAttributes)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Age, stream, typeof(Int32));
            Orleans.Serialization.SerializationManager.SerializeInner(input.FirstName, stream, typeof(String));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Gender, stream, typeof(GenderType));
            Orleans.Serialization.SerializationManager.SerializeInner(input.LastName, stream, typeof(String));
        }
        
        public static object Deserializer(System.Type expected, Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            Orleans.StorageProvider.Blob.TestInterfaces.PersonalAttributes result = new Orleans.StorageProvider.Blob.TestInterfaces.PersonalAttributes();
            result.Age = ((Int32)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(Int32), stream)));
            result.FirstName = ((String)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(String), stream)));
            result.Gender = ((GenderType)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(GenderType), stream)));
            result.LastName = ((String)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(String), stream)));
            return result;
        }
        
        public static void Register()
        {
            Orleans.Serialization.SerializationManager.Register(typeof(Orleans.StorageProvider.Blob.TestInterfaces.PersonalAttributes), DeepCopier, Serializer, Deserializer);
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
