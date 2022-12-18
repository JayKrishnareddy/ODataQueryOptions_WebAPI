using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using ODataQueryOptions_WebAPI.Models;

namespace ODataQueryOptions_WebAPI.DataBuilder
{
    public class ODataModelBuilder
    {
        public static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Product>("Products");
            builder.EntitySet<Sale>("Sales");
            return builder.GetEdmModel();
        }
    }
}
