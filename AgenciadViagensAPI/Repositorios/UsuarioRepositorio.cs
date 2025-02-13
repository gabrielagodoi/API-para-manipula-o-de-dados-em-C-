﻿
using AgenciadViagensAPI.Data;
using AgenciadViagensAPI.Models;
using AgenciadViagensAPI.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AgenciadViagensAPI.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio

    {
        private readonly SistemaViagemDBContex _dbContext;
        public UsuarioRepositorio(SistemaViagemDBContex sistemaViagemDBContex)
        {
            _dbContext = sistemaViagemDBContex;
        }

        public async Task<UsuarioModel> BuscarPorId(int Id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }
        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            return usuario;
        }

        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int Id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(Id);

            if (usuarioPorId == null)

                throw new Exception($"Usuario para o ID:  {Id} não foi encontrado no banco de dados.");

            usuarioPorId.Nome = usuario.Nome;
            usuarioPorId.Email = usuario.Email;

            _dbContext.Usuarios.Update(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return usuarioPorId;
        }
        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);

            if (usuarioPorId == null)

                throw new Exception($"Usuario para o ID:  {id} não foi encontrado no banco de dados.");


            _dbContext.Usuarios.Remove(usuarioPorId);
            await _dbContext.SaveChangesAsync();
            return true;

        }
    }
}
