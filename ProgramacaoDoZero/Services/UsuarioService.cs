using ProgramacaoDoZero.Common;
using ProgramacaoDoZero.Entities;
using ProgramacaoDoZero.Models;
using ProgramacaoDoZero.Repositories;
using System;

namespace ProgramacaoDoZero.Services
{
    public class UsuarioService
    {
        private string _connectionString;

        public UsuarioService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public LoginResult Login(string email, string senha)
        {
            var result = new LoginResult();

            var usuarioRepository = new UsuarioRepository(_connectionString);
            var usuario = usuarioRepository.ObterUsuarioPorEmail(email);

            if (usuario != null)
            {
                // usuario existe
                if (usuario.Senha == senha)
                {
                    // senha válida
                    result.sucesso = true;
                    result.usuarioGuid = usuario.UsuarioGuid;
                }
                else
                {
                    //senha invalida
                    result.sucesso = false;
                    result.mensagem = "Usuário ou senha inválidos.";
                }
            }
            else
            {
                // usuario não existe
                result.sucesso = false;
                result.mensagem = "Usuário ou senha inválidos.";
            }

            return result;
        }

        public CadastroResult Cadastro(string nome, string sobrenome, string cpf, string telefone, string genero, string email, string senha)
        {
            var result = new CadastroResult();

            var usuarioRepository = new UsuarioRepository(_connectionString);
            var usuario = usuarioRepository.ObterUsuarioPorEmail(email);

            if (usuario != null)
            {
                //usuario já existe
                result.sucesso = false;
                result.mensagem = "Usuário já existente no sistema";
            }
            else
            {
                //usuario nao existe
                usuario = new Usuario();

                usuario.Nome = nome;
                usuario.Sobrenome = sobrenome;
                usuario.Cpf = cpf;
                usuario.Telefone = telefone;
                usuario.Genero = genero;
                usuario.Email = email;
                usuario.Senha = senha;
                usuario.UsuarioGuid = System.Guid.NewGuid();

                var insertResult = usuarioRepository.Inserir(usuario);

                if (insertResult > 0)
                {
                    //inseriu com sucesso 
                    result.sucesso = true;
                    result.mensagem = "Usuário cadastrado com sucesso!";
                    result.usuarioGuid = usuario.UsuarioGuid;
                }
                else
                {
                    //erro ao inserir
                    result.sucesso = false;
                    result.mensagem = "Erro ao inserir usuário. Tente novamente";
                }
            }

            return result;
        }

        public EsqueceuSenhaResult EsqueceuSenha(string email)
        {
            var result = new EsqueceuSenhaResult();

            var usuarioRepository = new UsuarioRepository(_connectionString);
            var usuario = usuarioRepository.ObterUsuarioPorEmail(email);

            if (usuario == null)
            {
                // nao existe
                result.sucesso = false;
                result.mensagem = "Usuário não existente para esse email";
            }
            else
            {
                //usuario existe
                var emailSender = new EmailSender();

                var assunto = "Programação do Zero - Recuperação de Senha";
                var corpo = "Sua senha de acesso é " + usuario.Senha;

                emailSender.Enviar(assunto, corpo, usuario.Email);
            }

            return result;
        }

        public Usuario ObterUsuario(Guid usuarioGuid)
        {
            var usuario = new UsuarioRepository(_connectionString).ObterPorGuid(usuarioGuid);

            return usuario;
        }
    }
}
