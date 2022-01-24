using Localiza.Frotas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza.Frotas.Infra.Repository
{
    public class InMemoryRepository : IVeiculoRepository
    {
        private readonly IList<Veiculo> veiculoList = new List<Veiculo>();
        public void Add(Veiculo veiculo) => veiculoList.Add(veiculo);


        public void Delete(Veiculo veiculo) => veiculoList.Remove(veiculo);


        public IEnumerable<Veiculo> GetAll()
        {
            return veiculoList.ToList();
        }

        public Veiculo GetById(Guid id) => veiculoList.SingleOrDefault(x => x.Id == id);


        public void Update(Veiculo veiculo)
        {
            veiculoList.Remove(GetById(veiculo.Id));
            veiculoList.Add(veiculo);
        }

        } 
    }
