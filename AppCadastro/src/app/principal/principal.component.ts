import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Cliente } from '../models/Cliente';
import { Endereco } from '../models/Endereco';

@Component({
  selector: 'app-principal',
  templateUrl: './principal.component.html',
  styleUrls: ['./principal.component.css']
})
export class PrincipalComponent implements OnInit {

  public selecionar: Cliente;
  public selecEndereco: Endereco;
  public novoEnd: boolean;
  public formCadastro: FormGroup;
  public formAltEnd: FormGroup;

  public clientes = [
    { id: 1, nome: 'Jander Raul', tratamento: 'Raul', cpf: '122.111.111-00', tipo: 'Pessoa Fisica', dataNasc: '12', status: 'Ativo', dataInc: '121' },
    { id: 2, nome: 'Daiane Rodrigues', tratamento: 'Daia', cpf: '222.222.333-44', tipo: 'Pessoa Fisica', dataNasc: '12', status: 'Inativo', dataInc: '1212' },
  ];

  public enderecos = [
    { id: 1, endereco: 'Rua dos Jasmins', numero: '120', complemento: 'casa', bairro: 'JD Novo Hoje', cep: '12.222-000', cidade: 'Ribeirão Preto', estado: 'São Paulo', status: 'Ativo' },
    { id: 2, endereco: 'Rua das Oliveiras', numero: '234', complemento: '', bairro: 'JD Novo Amanhã', cep: '13.556-234', cidade: 'Ribeirão Preto', estado: 'São Paulo', status: 'Ativo' },
    
  ];

  criarFormCad(){
    this.formCadastro = this.fb.group({
      endereco: [''],
      numero: [''],
      complemento: [''],
      bairro: [''],
      cep: [''],
      cidade: [''],
      estado: [''],
      status: [''],
    });
  }

  criarFormAltEnd(){
    this.formAltEnd = this.fb.group({
      endereco: [''],
      numero: [''],
      complemento: [''],
      bairro: [''],
      cep: [''],
      cidade: [''],
      estado: [''],
      status: [''],
    });
  }

  alteraEnd(){
    console.log(this.formAltEnd.value);
    this.selecEndereco = null;
  }

  enviarCadastro(){
    console.log(this.formCadastro.value);
    this.novoEnd = false;
  }

  novoEndereco(){
    this.novoEnd = true;
  }

  novoEnderecoCancel(){
    this.novoEnd = false;
  }

  selecionarEndereco(end: Endereco){
    this.selecEndereco = end;
    this.formAltEnd.patchValue(end);
  }

  selecionarCliente(cadastro: Cliente){
    this.selecionar = cadastro;
  }

  cancelar(){
    this.selecEndereco = null;
  }

  voltar(){
    this.selecionar = null;
  }
  
  constructor(private fb: FormBuilder) {
    this.criarFormCad();
    this.criarFormAltEnd();
   }

  ngOnInit() {
  }

}
