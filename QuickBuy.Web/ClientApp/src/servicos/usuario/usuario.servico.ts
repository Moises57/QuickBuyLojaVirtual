import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Usuario } from "../../app/model/usuario";

//Isso indica que a classe UsuarioServico está sendo publicada na raíz do pojeto e todo sistema
//pode usar ela por meio de injeção de dependência
@Injectable({
  providedIn: "root"
})
export class UsuarioServico {

  private baseURL: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string, ) {

    this.baseURL = baseUrl;
  }

  public verificarUsuario(usuario: Usuario): Observable<Usuario> {

    //Cabeçalho
    const headers = new HttpHeaders().set('content-type', 'application/json');

    //Corpo
    var body = {
      email: usuario.email,
      senha: usuario.senha
    }

    //this.BaseURL = raiz do site que pode ser exemplo.:http://www.quickbuy.com/
    return this.http.post<Usuario>(this.baseURL + "api/usuario/VerificarUsuario", body, { headers });
    
  }
}
