export default function ComponenteListaLibro() {
    return (
      <div>
          <h1>Lista de Libros</h1>
          <table className="table table-hover table-bordered ">
            <thead className="table-dark">
              <tr>
                <th scope="col">Código</th>
                <th scope="col">Nombre</th>
                <th scope="col">Estado</th>
                <th scope="col">Código del Autor</th>
                <th scope="col"></th>
                <th scope="col"></th>
              </tr>
            </thead >
            <tbody>
              <tr>
                <th scope="row">1</th>
                <td>Los pajaros negros</td>
                <td>true</td>
                <td>1</td>
                <td><a href="#" className="btn btn-success">Registrar</a></td>
                <td><a href="#" className="btn btn-danger">Eliminar</a></td>
              </tr>
              <tr>
                <th scope="row">2</th>
                <td>Perla negra</td>
                <td>True</td>
                <td>2</td>
                <td><a href="#" className="btn btn-success">Registrar</a></td>
                <td><a href="#" className="btn btn-danger">Eliminar</a></td>
              </tr>
              <tr>
                <th scope="row">3</th>
                <td>La ciudad de los perros</td>
                <td>False</td>
                <td>3</td>
                <td><a href="#" className="btn btn-success">Registrar</a></td>
                <td><a href="#" className="btn btn-danger">Eliminar</a></td>
              </tr>
            </tbody>
          </table>
        <a href="autores/registrar" className="btn btn-primary">Registrar Libro</a>
      </div>
    );
  }
  