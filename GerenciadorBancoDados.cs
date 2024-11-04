public class GerenciadorBancoDados
{
    private static GerenciadorBancoDados _instancia;
    private static readonly object _lock = new object();

    private GerenciadorBancoDados()
    {
        // começo da conexao com o banco de dados
    }

    public static GerenciadorBancoDados Instancia
    {
        get
        {
            lock (_lock)
            {
                if (_instancia == null)
                {
                    _instancia = new GerenciadorBancoDados();
                }
                return _instancia;
            }
        }
    }
}
X