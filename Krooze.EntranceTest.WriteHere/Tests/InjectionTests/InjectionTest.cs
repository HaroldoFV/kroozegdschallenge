using System;
using System.Collections.Generic;
using System.Reflection;
using Krooze.EntranceTest.WriteHere.Structure.Model;

namespace Krooze.EntranceTest.WriteHere.Tests.InjectionTests
{
    public class InjectionTest
    {
        public List<CruiseDTO> GetCruises(CruiseRequestDTO request)
        {
            //TODO: This method receives a generic request, that has a cruise company code on it
            //There is an interface (IGetCruise) that is implemented by 3 classes (Company1, Company2 and Company3)
            //Make sure that the correct class is injected based on the CruiseCompanyCode on the request
            //without directly referencing the 3 classes and the method GetCruises of the chosen implementation is called
            //return null;

            Type t = null;

            if (request.CruiseCompanyCode == 1)
            {
                t = Type.GetType("Krooze.EntranceTest.WriteHere.Structure.Implementations.Company1");
                ConstructorInfo ctor = t.GetConstructor(Type.EmptyTypes);
                var obj = ctor.Invoke(null);
                MethodInfo mi = t.GetMethod("GetCruises");
                var list = mi.Invoke(obj, new Object[] { request });
                return (List<CruiseDTO>)list;
            }
            else if (request.CruiseCompanyCode == 2)
            {
                t = Type.GetType("Krooze.EntranceTest.WriteHere.Structure.Implementations.Company2");
                ConstructorInfo ctor = t.GetConstructor(Type.EmptyTypes);
                var obj = ctor.Invoke(null);
                MethodInfo mi = t.GetMethod("GetCruises");
                var list = mi.Invoke(obj, new Object[] { request });
                return (List<CruiseDTO>)list;
            }
            else if (request.CruiseCompanyCode == 3)
            {
                t = Type.GetType("Krooze.EntranceTest.WriteHere.Structure.Implementations.Company3");
                ConstructorInfo ctor = t.GetConstructor(Type.EmptyTypes);
                var obj = ctor.Invoke(null);
                MethodInfo mi = t.GetMethod("GetCruises");
                var list = mi.Invoke(obj, new Object[] { request });
                return (List<CruiseDTO>)list;
            }

            return null;
        }
    }
}
