using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class RepositorioNoticias
    {
        private static List<Noticia> noticias;

        public static List<Noticia> Noticias
        {
            get
            {
                if (noticias == null)
                    CriarNoticias();
                return noticias;
            }
        }

        private static void CriarNoticias()
        {
            noticias = new List<Noticia>();
            noticias.Add(new Noticia
            {
                Id = 1,
                Titulo = "Apa itu Lorem Ipsum?",
                Autor = "Joao Silva",
                Data = DateTime.Today,
                Conteudo = "pencetakan dan typesetting. Lorem Ipsum telah menjadi text contoh semenjak tahun ke 1500an, apabila pencetak yang kurang terkenal mengambil sebuah galeri cetak dan merobakanya"
            });

            noticias.Add(new Noticia
            {
                Id = 2,
                Titulo = "Lorem Ipsum?",
                Autor = "Marcos Barbosa",
                Data = DateTime.Today,
                Conteudo = "Apabila pencetak yang kurang terkenal mengambil sebuah galeri cetak dan merobakanya"
            });

            noticias.Add(new Noticia
            {
                Id = 3,
                Titulo = "Apa itu",
                Autor = "Joyce Santos",
                Data = DateTime.Today,
                Conteudo = "pencetakan dan typesetting. Lorem Ipsum telah menjadi text contoh semenjak tahun ke 1500an."
            });

            noticias.Add(new Noticia
            {
                Id = 4,
                Titulo = "itu Lorem",
                Autor = "Alan Souza",
                Data = DateTime.Today,
                Conteudo = "Lorem Ipsum telah menjadi text contoh."
            });

            noticias.Add(new Noticia
            {
                Id = 5,
                Titulo = "Ipsum?",
                Autor = "Lorem Ipsum",
                Data = DateTime.Today,
                Conteudo = "pencetakan dan typesetting. Lorem Ipsum telah menjadi text contoh semenjak tahun ke 1500an, apabila pencetak yang kurang terkenal mengambil sebuah galeri cetak dan merobakanya"
            });
        }
    }
}