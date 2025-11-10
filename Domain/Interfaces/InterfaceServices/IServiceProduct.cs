/*
 * A interface IServiceProdutct vai ser diferente dos métodos genéricos, aqui 
 * podemos colocar regras de negócio específicas para o serviço de Produto.
 * 
 */


using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceServices
{
    public  interface IServiceProduct
    {
        Task AddProduct(Produto produto);
        Task UpdateProduct(Produto produto);
    }
}
