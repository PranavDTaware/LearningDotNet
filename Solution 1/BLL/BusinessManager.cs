using Catalog;
using DAL;


namespace BLL
{
    public static class BusinessManager
    {
        public static Product GetProduct(int id)
        {
            ICatalogDBManager mgr = new CatalogDBConnectedManager();
            return mgr.GetProductByID(id);
        }

        public static IEnumerable<Product> GetAllProducts()
        {

            //IEnumerable<Product> allProducts = CatalogDBManager.GetAllProducts();

            ICatalogDBManager mgr = new CatalogDBConnectedManager();
            IEnumerable<Product> allProducts = mgr.GetAllProducts();
            #region hardcoded way
            /* List<Product> allProducts = new List<Product>();
               allProducts.Add(new Product{ Id = 1, Title = "Rose", Description = "A beautiful red rose with a sweet fragrance.", UnitPrice = 12, Quantity = 5000 });
               allProducts.Add(new Product { Id = 2, Title = "Tulip", Description = "A vibrant yellow tulip, perfect for spring.", UnitPrice = 20, Quantity = 0 });
               allProducts.Add(new Product { Id = 3, Title = "Lily", Description = "Elegant white lilies with a delicate scent.", UnitPrice = 10, Quantity = 2000 });
               allProducts.Add(new Product { Id = 4, Title = "Daffodil", Description = "Bright orange daffodils to brighten any garden.", UnitPrice = 15, Quantity = 21000 });
               allProducts.Add(new Product { Id = 5, Title = "Sunflower", Description = "A tall sunflower with bright yellow petals.", UnitPrice = 10, Quantity = 0 });
               allProducts.Add(new Product { Id = 6, Title = "Orchid", Description = "Exotic orchids with vibrant purple flowers.", UnitPrice = 15, Quantity = 15000 });
               allProducts.Add(new Product { Id = 8, Title = "Lavender", Description = "Aromatic lavender flowers, perfect for relaxation.", UnitPrice = 7, Quantity = 0 });
             */
            #endregion

            return allProducts;
        }


        public static IEnumerable<Product> GetSoldOutProducts()
        {
            IEnumerable<Product> products = GetAllProducts();
            return products;
            //Apply filter
            //Apply some buisness query
            //LINQ : Language Integrated Query
            //var soldOutProducts = from product in products select product;
            //var soldOutProducts = from product in products
            //                      where product.Quantity == 0 
            //                      select product;


            //return soldOutProducts;
        }


        public static bool InsertProduct(Product newProduct)
        {
            ICatalogDBManager mgr = new CatalogDBConnectedManager();

            return mgr.Insert(newProduct);
        }

        public static bool UpdateProduct(Product theproduct)<DirectedGraph xmlns="http://schemas.microsoft.com/vs/2009/dgml">
  <Nodes>
    <Node Id="(@1 Namespace=DAL Type=CatalogDBConnectedManager Member=(Name=DAL.ICatalogDBManager.Delete OverloadingParameters=[(@2 Namespace=System Type=Int32)]))" Category="CodeSchema_Method" CodeSchemaProperty_IsPrivate="True" CommonLabel="DAL.ICatalogDBManager.Delete" Icon="Microsoft.VisualStudio.Method.Private" IsDragSource="True" Label="ICatalogDBManager.Delete(int) : bool" SourceLocation="(Assembly=&quot;file:///I:/FullStack/LearningDotNet/Solution 1/DAL/CatalogDBConnectedManager.cs&quot; StartLineNumber=201 StartCharacterOffset=32 EndLineNumber=201 EndCharacterOffset=38)" />
    <Node Id="(@1 Namespace=DAL Type=CatalogDBConnectedManager)" Visibility="Hidden" />
  </Nodes>
  <Links>
    <Link Source="(@1 Namespace=DAL Type=CatalogDBConnectedManager)" Target="(@1 Namespace=DAL Type=CatalogDBConnectedManager Member=(Name=DAL.ICatalogDBManager.Delete OverloadingParameters=[(@2 Namespace=System Type=Int32)]))" Category="Contains" />
  </Links>
  <Categories>
    <Category Id="CodeSchema_Member" Label="Member" Icon="CodeSchema_Field" />
    <Category Id="CodeSchema_Method" Label="Method" BasedOn="CodeSchema_Member" Icon="CodeSchema_Method" />
    <Category Id="Contains" Label="Contains" Description="Whether the source of the link contains the target object" IsContainment="True" />
  </Categories>
  <Properties>
    <Property Id="CodeSchemaProperty_IsPrivate" Label="Is Private" Description="Flag to indicate the scope is Private" DataType="System.Boolean" />
    <Property Id="CommonLabel" DataType="System.String" />
    <Property Id="Icon" Label="Icon" DataType="System.String" />
    <Property Id="IsContainment" DataType="System.Boolean" />
    <Property Id="IsDragSource" Label="IsDragSource" Description="IsDragSource" DataType="System.Boolean" />
    <Property Id="Label" Label="Label" Description="Displayable label of an Annotatable object" DataType="System.String" />
    <Property Id="SourceLocation" Label="Start Line Number" DataType="Microsoft.VisualStudio.GraphModel.CodeSchema.SourceLocation" />
    <Property Id="Visibility" Label="Visibility" Description="Defines whether a node in the graph is visible or not" DataType="System.Windows.Visibility" />
  </Properties>
  <QualifiedNames>
    <Name Id="Assembly" Label="Assembly" ValueType="Uri" />
    <Name Id="Member" Label="Member" ValueType="System.Object" />
    <Name Id="Name" Label="Name" ValueType="System.String" />
    <Name Id="Namespace" Label="Namespace" ValueType="System.String" />
    <Name Id="OverloadingParameters" Label="Parameter" ValueType="Microsoft.VisualStudio.GraphModel.GraphNodeIdCollection" Formatter="NameValueNoEscape" />
    <Name Id="Type" Label="Type" ValueType="System.Object" />
  </QualifiedNames>
  <IdentifierAliases>
    <Alias n="1" Uri="Assembly=$(70c85903-ead0-4bdc-88e4-2c99fd533dbc.OutputPathUri)" />
    <Alias n="2" Uri="Assembly=$(ProgramFilesUri)/dotnet/packs/Microsoft.NETCore.App.Ref/8.0.11/ref/net8.0/System.Runtime.dll" />
  </IdentifierAliases>
  <Paths>
    <Path Id="70c85903-ead0-4bdc-88e4-2c99fd533dbc.OutputPathUri" Value="file:///I:/FullStack/LearningDotNet/Solution 1/DAL/bin/Debug/net8.0/DAL.dll" />
    <Path Id="ProgramFilesUri" Value="file:///C:/Program Files" />
  </Paths>
</DirectedGraph>
        {
            ICatalogDBManager mgr = new CatalogDBConnectedManager();

            return mgr.Update(theproduct);
        }

        public static bool DeleteProduct(int id)
        {
            ICatalogDBManager mgr = new CatalogDBConnectedManager();

            return mgr.Delete(id);
        }

    }
}
