﻿using acme.sistemas.compracoletiva.core.Base;
using acme.sistemas.compracoletiva.core.Dtos.Utils;
using acme.sistemas.compracoletiva.domain.Entity.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Utils
{
    public class Pagamento : BaseEntity, IAggregateRoot
    {
        public Pagamento(PagamentoDto pagamentoDto)
        {
            DataPagamento = pagamentoDto.DataPagamento;
            DataEmQueDinheiroCaiNaConta = pagamentoDto.DataEmQueDinheiroCaiNaConta;
            NomePagador = pagamentoDto.NomePagador;
            ValorRecebido = pagamentoDto.ValorRecebido;
            ValorAReceber = pagamentoDto.ValorAReceber;
            DataPrevistaPagamento = pagamentoDto.DataPrevistaPagamento;
            DataVencimento = pagamentoDto.DataVencimento;
        }

        protected Pagamento()
        {

        }

        public DateTime DataPagamento { get; set; }
        public DateTime DataEmQueDinheiroCaiNaConta { get; set; }
        public string NomePagador { get; set; }
        public decimal ValorRecebido { get; set; }
        public decimal ValorAReceber { get; set; }
        public DateTime DataPrevistaPagamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public Guid? UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }


        public void Atualizar(Pagamento pagamento)
        {
            if (this.DataPagamento != pagamento.DataPagamento)
                DataPagamento = pagamento.DataPagamento;

            if (this.DataEmQueDinheiroCaiNaConta != pagamento.DataEmQueDinheiroCaiNaConta)
                DataEmQueDinheiroCaiNaConta = pagamento.DataEmQueDinheiroCaiNaConta;

            if (this.NomePagador != pagamento.NomePagador)
                NomePagador = pagamento.NomePagador;

            if (this.ValorRecebido != pagamento.ValorRecebido)
                ValorRecebido = pagamento.ValorRecebido;

            if (this.ValorAReceber != pagamento.ValorAReceber)
                ValorAReceber = pagamento.ValorAReceber;

            if (this.DataPrevistaPagamento != pagamento.DataPrevistaPagamento)
                DataPrevistaPagamento = pagamento.DataPrevistaPagamento;

            if (this.DataVencimento != pagamento.DataVencimento)
                DataVencimento = pagamento.DataVencimento;

            if (this.UsuarioId != pagamento.UsuarioId)
                UsuarioId = pagamento.UsuarioId;


            base.Atualizar(pagamento.UsuarioModificacaoId);
        }

        public void Pagar(PagamentoDto pagamentoDto)
        {
            DataPagamento = pagamentoDto.DataPagamento;
            ValorRecebido = pagamentoDto.ValorRecebido;
            ValorAReceber = pagamentoDto.ValorAReceber;
            NomePagador = pagamentoDto.NomePagador;
            DataVencimento = pagamentoDto.DataVencimento;
            UsuarioId = pagamentoDto.UsuarioId;
        }
    }
}
