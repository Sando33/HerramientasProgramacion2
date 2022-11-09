import { useParams } from "react-router-dom"

export default function ComponenteActualizarAutor() {
  //Creamos una variable para capturar el codigo que se va actualizar
  const {id}:any=useParams();  
  return (
      <div>
          <h1>Actualización de Autores</h1>
          <h2>El id es:{id}</h2>
      </div>
    );
  }
  