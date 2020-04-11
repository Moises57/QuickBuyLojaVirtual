import { Component, OnInit } from '@angular/core';
import { Usuario } from '../../model/usuario';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent implements OnInit {

  public usuario;
  public returnUrl: string;

  constructor(private router: Router, private activatedRouter: ActivatedRoute) {
    this.usuario = new Usuario();
    
  }

  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
  }

  entrar() {
    if (this.usuario.email == "moises-dba1@hotmail.com" && this.usuario.senha == "seladoraconjugado") {
      sessionStorage.setItem("usuario-autenticado", "1");
      this.router.navigate([this.returnUrl]);
    }
  }
}
