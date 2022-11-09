import ComponenteActualizarAutor from "./autores/ComponenteActualizarAutor";
import ComponenteListaAutor from "./autores/ComponenteListaAutor";
import ComponenteRegistrarAutor from "./autores/ComponenteRegistrarAutor";
import ComponentePrincipal from "./ComponentesPrincipal/ComponentePrincipal";
import ComponenteRegistrarLibro from "./libros/ComponenteRegistrarLibro";
import ComponenteListaLibro from "./libros/ComponenteListaLibro";
import ComponenteActualizarLibro from "./libros/ComponenteActualizarLibro";
import ComponenteRedireccionar from "./ComponentesPrincipal/ComponenteRedireccionar";
const rutas=[
{path:'/inicio',componente:ComponentePrincipal },
{path:'/autores',componente:ComponenteListaAutor},
{path:'/autores/registrar',componente:ComponenteRegistrarAutor},
{path:'/autores/actualizar/:id',componente:ComponenteActualizarAutor},
{path:'/libros',componente:ComponenteListaLibro},
{path:'/libros/registrar',componente:ComponenteRegistrarLibro},
{path:'/libros/actualizar',componente:ComponenteActualizarLibro},

//Crando un path para rutas no encontradas, esto simepre va al final
{path:'*',componente:ComponenteRedireccionar}
];

export default rutas;