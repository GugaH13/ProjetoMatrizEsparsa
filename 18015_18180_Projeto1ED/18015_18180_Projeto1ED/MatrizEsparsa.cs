﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MatrizEsparsa
{
    Celula noCabeca;
    int numeroLinhas, numeroColunas;

    public Celula NoCabeca { get => noCabeca; set => noCabeca = value; }
    public int NumeroLinhas { get => numeroLinhas; set => numeroLinhas = value; }
    public int NumeroColunas { get => numeroColunas; set => numeroColunas = value; }

    public MatrizEsparsa()
    {
        this.noCabeca = null;
        this.numeroLinhas = this.numeroColunas = 0;
    }
    public MatrizEsparsa(int nLinhas, int nColunas)
    {
        this.numeroLinhas = nLinhas;
        this.numeroColunas = nColunas;
        CriarNosCabeca(nLinhas, nColunas);
    }

    public bool EstaVazia()
    {
        bool vazia = true;
        Celula atualC = noCabeca.Direita;
        while (atualC != noCabeca && vazia == true)
        {
            if (atualC.Abaixo != atualC)
                vazia = false;
            atualC = atualC.Direita;
        }
        return vazia;
    }

    public void Inserir(Celula novaCelula)
    {
        Celula esq, dir, cima, baixo;
        esq = dir = cima = baixo = null;
        if (!ExisteDado(novaCelula, ref cima, ref esq, ref dir, ref baixo))
        {
            cima.Abaixo = novaCelula;
            esq.Direita = novaCelula;
            novaCelula.Abaixo = baixo;
            novaCelula.Direita = dir;
        }
    }
    public void RemoverCelula(Celula celulaARemover)
    {
        Celula esq, dir, cima, baixo;
        esq = dir = cima = baixo = null;
        if (ExisteDado(celulaARemover, ref cima, ref esq, ref dir, ref baixo))
        {
            cima.Abaixo = baixo;
            esq.Direita = dir; 
        }
    }
    protected void CriarNosCabeca(int nLinhas, int nColunas)
    {
        int c = default(int);
        bool primeiraVez = true;
        Celula anterior = this.noCabeca;
        for (int l = -1; l <= nLinhas; l++)
        {
            if (l == -1)
                for (c = -1; c <= nColunas; c++)
                {
                    if (l == -1 && c == -1)
                    {
                        
                        this.noCabeca = new Celula(default(double), l, c, default(Celula), default(Celula));
                        anterior = this.noCabeca;
                    }
                    else
                    {
                        if (c == nColunas)
                        {
                            anterior.Direita = new Celula(default(double), l, c, anterior.Direita, default(Celula));
                        }
                        else
                        {
                            anterior.Direita = new Celula(default(double), l, c, default(Celula), default(Celula));//como está vazia seu direita recebe a si mesma
                            anterior = anterior.Direita;
                        }

                    }
                }
            else
            {
                if (primeiraVez == true)
                {
                    anterior = this.noCabeca;
                    primeiraVez = false;
                    c = -1;
                }
                if (l == nLinhas)
                {
                    anterior.Abaixo = this.noCabeca;
                }
                else
                {
                    anterior.Abaixo = new Celula(default(double), l, c, anterior.Abaixo, null);
                    anterior = anterior.Abaixo;
                }
                
            }
        }
    }

    protected bool ExisteDado(Celula celulaNova, ref Celula cima, ref Celula esq, ref Celula dir, ref Celula baixo)
    {
        bool achou = false;
        if (EstaVazia())
        {
            cima = noCabeca.Direita;
            esq = noCabeca.Abaixo;
            dir = noCabeca.Abaixo;
            baixo = noCabeca.Direita;
            achou = false;
        }
        else
        {
            Celula atualC = noCabeca.Direita,
            atualL = noCabeca.Abaixo;
            while (atualC.Coluna != celulaNova.Coluna || atualL.Linha != celulaNova.Linha)
            {
                if (atualC.Coluna != celulaNova.Coluna && atualC != noCabeca)
                {
                    atualC = atualC.Direita;
                }
                if (atualL.Linha != celulaNova.Linha && atualL != noCabeca)
                {
                    atualL = atualL.Abaixo;
                }
            }
            Celula noCabecaC = atualC;
            Celula noCabecaL = atualL;
            bool achouAcima = false;
            while (achouAcima == false)
            {
                if (atualC.Abaixo == noCabecaC)
                {
                    achouAcima = true;
                    cima = atualC;
                    achou = false;
                    baixo = atualC.Abaixo;
                }
                else
                if (atualC.Abaixo.Valor == celulaNova.Valor && 
                    atualC.Abaixo.Coluna == celulaNova.Coluna &&
                    atualC.Abaixo.Linha == celulaNova.Linha)
                {
                    achou = true;
                    cima = atualC;
                    baixo = atualC.Abaixo;
                    achouAcima = true;
                }
                else
                if (atualC.Abaixo.Linha < celulaNova.Linha)
                {
                    atualC = atualC.Abaixo;
                }
                else
                if (atualC.Abaixo.Linha > celulaNova.Linha) 
                {
                    cima = atualC;
                    achou = false;
                    achouAcima = true;
                    baixo = atualC.Abaixo;
                }
            }
            bool achouEsq = false;
            while (achouEsq == false)
            {
                if (atualL.Direita.Coluna > celulaNova.Coluna)
                {
                    esq = atualL;
                    achouEsq = true;
                    dir = atualL.Direita;
                }
                else
                if (atualL.Direita == noCabecaL)
                {
                    esq = atualL;
                    achouEsq = true;
                    dir = atualL.Direita;
                }
                if (atualL.Direita.Valor == celulaNova.Valor &&
                    atualL.Direita.Coluna == celulaNova.Coluna &&
                    atualL.Direita.Linha == celulaNova.Linha)
                {
                    achouEsq = true;
                    esq = atualL;
                    dir = atualL.Direita.Direita;
                }
                else
                atualL = atualL.Direita;
                
            }

        }
        return achou;

    }
}
