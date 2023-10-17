using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Creating_a_Custom_Container
{
    public class DiContainer
    {
        private Dictionary<Type,Type> _type = new Dictionary<Type, Type>();

        public void Register<TInterface, TType>()
        {
            if (_type.ContainsKey(typeof(TInterface)))
            {
                throw new Exception("Type already registered");
            }
            _type.Add(typeof(TInterface), typeof(TType));
        }

        public TInterface Resolve<TInterface>()
        {
            return (TInterface)GetImplementation(typeof(TInterface));
        }

        private object GetImplementation(Type type)
        {
            if(!_type.ContainsKey(type))
            {
                throw new Exception("Type does not exist");
            }
            Type implementation = _type.GetValueOrDefault(type);
            ConstructorInfo constructorInfo = implementation.GetConstructors()[0];
            var constructorParmType = constructorInfo.GetParameters();
            List<object> parameters = new List<object>();
            foreach(var param in constructorParmType)
            {
                parameters.Add(GetImplementation(param.ParameterType));
            }
            return constructorInfo.Invoke(parameters.ToArray());
        }

    }
}
