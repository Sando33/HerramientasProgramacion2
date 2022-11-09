export default function ComponenteMenu() {
  return (
    <nav className="navbar navbar-expand-md bg-dark navbar-dark">
      <a className="navbar-brand" href="#">
        Api - Autores
      </a>

      <button
        className="navbar-toggler"
        type="button"
        data-toggle="collapse"
        data-target="#collapsibleNavbar">
        <span className="navbar-toggler-icon"></span>
      </button>

      <div className="collapse navbar-collapse" id="collapsibleNavbar">
        <ul className="navbar-nav">
          <li className="nav-item">
            <a className="nav-link" href="/inicio">
              Inicio
            </a>
          </li>
          <li className="nav-item">
            <a className="nav-link" href="/autores">
              Autores
            </a>
          </li>
          <li className="nav-item">
            <a className="nav-link" href="/libros">
              Libros
            </a>
          </li>
        </ul>
      </div>
    </nav>
  );
}
