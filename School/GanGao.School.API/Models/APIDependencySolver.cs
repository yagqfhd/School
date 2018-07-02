using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Dependencies;

namespace GanGao.School.API.Models
{
    
    public class APIDependencySolver : IDependencyResolver
    {
        private static CompositionContainer _container;
        private readonly ComposablePartCatalog _catalog;

        public APIDependencySolver(ComposablePartCatalog catalog)
        {
            _catalog = catalog;
        }

        public CompositionContainer Container
        {
            get
            {
                if (_container==null)
                {
                    _container =  new CompositionContainer(_catalog);
                }                
                return _container;
            }
        }

        #region IDependencyResolver Members

        public object GetService(Type serviceType)
        {
            string contractName = AttributedModelServices.GetContractName(serviceType);
            return Container.GetExportedValueOrDefault<object>(contractName);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Container.GetExportedValues<object>(serviceType.FullName);
        }
        /// <summary>
        /// BeginScope
        /// </summary>
        /// <returns></returns>
        public IDependencyScope BeginScope()
        {
            return new APIDependencySolver(_catalog);
        }

        #endregion

        public void Dispose()
        {
            //ToDo
        }

    }
}