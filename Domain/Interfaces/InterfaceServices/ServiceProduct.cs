using Domain.Interfaces.InterfaceProduct;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceServices
{
    public class ServiceProduct : IServiceProduct
    {
        //Construtor com ijeção de dependência  para trazer os métodos genéricos do IProduct
        private readonly IProduct _IProduct;

        public ServiceProduct(IProduct IProduct)
        {
            _IProduct = IProduct;
        }

        //Implementando as regras de negócio para o serviço de Produto
        public async Task AddProduct(Produto produto)
        {
            var validaNome = produto.ValidarPropriedadeString(produto.Nome, "Nome");
            var valiValor = produto.ValidarPropriedadeDecimal(produto.Valor, "Valor");
            if (validaNome && valiValor)
            {
               produto.Estado = true;
               await _IProduct.Add(produto);
            }

        }

        public async Task UpdateProduct(Produto produto)
        {
            var validaNome = produto.ValidarPropriedadeString(produto.Nome, "Nome");
            var valiValor = produto.ValidarPropriedadeDecimal(produto.Valor, "Valor");
            if (validaNome && valiValor)
            {
                await _IProduct.Update(produto);
            }
        }
    }
}
