using Microsoft.FeatureManagement;

namespace FeatureFlag.Example.Services
{
    public sealed class MyService
    {
        private readonly IFeatureManager _featureManager;

        public MyService(IFeatureManager featureManager)
        {
            _featureManager = featureManager;
        }

        public async Task<string> Process()
        {
            // Verifica se o recurso "NovoMetodo" está habilitado
            if (await _featureManager.IsEnabledAsync("NovoMetodo"))
            {
                return NovoMetodo();
            }
            else
            {
                return MetodoAntigo();
            }
        }
        public string NovoMetodo()
        {
            return "Novo Método";
        }
        public string MetodoAntigo()
        {
            return "Método legado";
        }
    }
}
