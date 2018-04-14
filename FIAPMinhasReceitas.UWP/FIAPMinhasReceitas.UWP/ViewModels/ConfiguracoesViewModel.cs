using FIAPMinhasReceitas.Models.Abstracts;
using FIAPMinhasReceitas.UWP.Services;

namespace FIAPMinhasReceitas.UWP.ViewModels
{
    public class ConfiguracoesViewModel : NotifyableClass
    {
        private int? _ordemListaReceitasConfiguracao;

        public int? OrdemListaReceitasConfiguracao
        {
            get
            {
                return StorageService.LerConfiguracao(StorageService.Configuracoes.OrdemListaReceitas, 0);
            }
            set
            {
                StorageService.GravarConfiguracao(StorageService.Configuracoes.OrdemListaReceitas, value);
            }
        }
    }
}
