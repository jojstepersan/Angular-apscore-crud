import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-libros',
  templateUrl: './libros.component.html'
})

export class LibrosComponent {
  public libro: Libros[];
  private http: HttpClient;
  private baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;   
  }

  onFilter() {
    var autor = document.getElementById("autor").value;
    var titulo = document.getElementById("titulo").value;
    var anho = document.getElementById("anho").value;
    var genero = document.getElementById("genero").value;
    var editorial = document.getElementById("editorial").value;

    var api = "api/libro?";
    if (autor != "")
      api += "&autor=" + autor;
    if (titulo != "")
      api += "&titulo=" + titulo;
    if (anho != "")
      api += "&anho=" + anho;
    if (genero != "")
      api += "&genero=" + genero;
    if (editorial != "")
      api += "&editorial=" + editorial;
    this.http.get<Libros[]>(this.baseUrl +api ).subscribe(result => {
      this.libro = result;
    }, error => console.error(error));
  } 

}

interface Libros {
  titulo: string;
  anho: number;
  numPaginas: number;
  nameAutor: string;
  nameEditorial: string;
  nameGenero: string;
}
