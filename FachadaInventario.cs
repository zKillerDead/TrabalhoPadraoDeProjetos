public class FachadaInventario
{
    private GerenciamentoProdutos _gerenciamentoProdutos;
    private ProcessamentoPedidos _processamentoPedidos;
    private RelacionamentoClientes _relacionamentoClientes;

    public FachadaInventario()
    {
        _gerenciamentoProdutos = new GerenciamentoProdutos();
        _processamentoPedidos = new ProcessamentoPedidos();
        _relacionamentoClientes = new RelacionamentoClientes();
    }

    public void AdicionarProduto(Produto produto)
    {
        _gerenciamentoProdutos.AdicionarProduto(produto);
    }

    public void ProcessarPedido(Pedido pedido)
    {
        _processamentoPedidos.ProcessarPedido(pedido);
    }

    public void TratarConsultaCliente(Cliente cliente)
    {
        _relacionamentoClientes.TratarConsulta(cliente);
    }
}
