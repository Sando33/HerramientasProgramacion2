export default function ComponenteListaAutor() {
  return (
    <div>
        <h1>Lista de Autores</h1>
        <table className="table table-hover table-bordered ">
            <thead className="table-dark">
              <tr>
                <th scope="col">Código</th>
                <th scope="col">Nombre</th>
                <th scope="col">Estado</th>
                <th scope="col"></th>
                <th scope="col"></th>
              </tr>
            </thead >
            <tbody>
              <tr>
                <th scope="row">1</th>
                <td>Gustavo Adolfo Veker</td>
                <td>true</td>
                <td><a href="#" className="btn btn-success">Registrar</a></td>
                <td><a href="#" className="btn btn-danger">Eliminar</a></td>
              </tr>
              <tr>
                <th scope="row">2</th>
                <td>Mario Vargas Llosa</td>
                <td>True</td>
                <td><a href="#" className="btn btn-success">Registrar</a></td>
                <td><a href="#" className="btn btn-danger">Eliminar</a></td>
              </tr>
              <tr>
                <th scope="row">3</th>
                <td>Pablo Nedura</td>
                <td>False</td>
                <td><a href="#" className="btn btn-success">Registrar</a></td>
                <td><a href="#" className="btn btn-danger">Eliminar</a></td>
              </tr>
            </tbody>
          </table>
        <a href="autores/registrar" className="btn btn-primary">Registrar Autor</a>
    </div>
  );
}
