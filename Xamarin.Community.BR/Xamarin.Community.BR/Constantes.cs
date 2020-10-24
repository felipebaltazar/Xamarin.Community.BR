﻿namespace Xamarin.Community.BR
{
    public static class Constantes
    {
        public static class Gravatar
        {
            public const string URL_BASE = "";
        }

        public static class SVG
        {
            public static class Xamarino
            {
                public const string FUNDO = "M128.675 53L101.175 5.09999C99.3749 2.09999 95.9749 0.1 92.4749 0H37.4749C33.9749 0 30.5749 1.99999 28.7749 5.09999L1.27494 53C-0.425061 56.1 -0.425061 60.1 1.27494 63.1L28.7749 111C30.5749 114 33.9749 116 37.4749 116.1H92.4749C95.9749 116.1 99.3749 114.1 101.175 111L128.675 63.1C130.375 60.1 130.375 56.1 128.675 53Z";

                public static class Frente
                {
                    public const string OLHO_DIREITO_PISCANDO = "M61.0388 55.099L43.9487 38.899C42.6494 37.699 40.8504 36.999 38.8516 36.999C38.0521 36.999 37.3525 37.099 36.5529 37.299C34.0544 37.999 32.3554 39.899 32.3554 41.899V73.999C32.3554 75.999 34.0544 77.899 36.5529 78.599C37.2525 78.799 38.0521 78.899 38.8516 78.899C40.8504 78.899 42.6494 78.199 43.8487 77.099L60.9389 61.099C61.8383 60.199 62.438 59.099 62.438 57.999C62.438 57.099 61.9383 55.999 61.0388 55.099ZM55.7418 59.099L41.2502 72.699C40.9504 72.999 40.5506 73.099 40.1508 73.099C39.951 73.099 39.851 73.099 39.6511 72.999C39.0515 72.799 38.6517 72.299 38.6517 71.599V59.599L56.1416 58.399C56.1416 58.599 56.0417 58.899 55.7418 59.099Z";
                    public const string OLHO_DIREITO_FECHADO = "M61.074 55.0516L43.974 38.9654C42.774 37.7665 40.874 37.0671 38.974 37.0671C38.174 37.0671 37.474 37.167 36.674 37.3668C34.174 38.0662 32.474 39.9646 32.474 41.9629V74.0352C32.474 76.0335 34.174 77.9319 36.674 78.6313C37.374 78.8311 38.174 78.931 38.974 78.931C40.974 78.931 42.774 78.2316 43.974 77.1326L61.074 61.1463C61.974 60.2471 62.574 59.1481 62.574 58.049C62.474 57.0499 61.974 55.9508 61.074 55.0516Z";
                    public const string OLHO_DIREITO_ABERTO = "M32.3739 41.999V74.099C32.3739 76.099 34.0739 77.999 36.5739 78.699C37.2739 78.899 38.0739 78.999 38.8739 78.999C40.8739 78.999 42.6739 78.299 43.8739 77.199L60.9739 61.199C61.8739 60.299 62.4739 59.199 62.4739 58.099C62.4739 56.999 61.9739 55.899 61.0739 54.999L43.9739 38.799C42.6739 37.599 40.8739 36.899 38.8739 36.899C38.0739 36.899 37.3739 36.999 36.5739 37.199C34.0739 38.099 32.3739 39.999 32.3739 41.999ZM38.6739 44.499C38.6739 43.899 39.0739 43.299 39.7739 43.099C40.2739 42.899 40.9739 43.099 41.3739 43.399L55.8739 56.999C56.1739 57.299 56.2739 57.599 56.2739 57.999C56.2739 58.399 56.0739 58.699 55.8739 58.999L41.3739 72.599C41.0739 72.899 40.6739 72.999 40.2739 72.999C40.0739 72.999 39.9739 72.999 39.7739 72.899C39.1739 72.699 38.7739 72.199 38.7739 71.499V44.499H38.6739Z";

                    public const string OLHO_ESQUERDO_PISCANDO = "M93.3202 37.399C92.6206 37.199 91.821 37.099 91.0215 37.099C89.0227 37.099 87.2237 37.799 86.0244 38.899L68.9342 54.899C68.0348 55.799 67.4351 56.899 67.4351 57.999C67.4351 59.099 67.9348 60.199 68.8343 61.099L85.9244 77.299C87.7234 78.999 90.6217 79.599 93.2202 78.799C95.7188 78.099 97.4178 76.199 97.4178 74.199V41.999C97.5178 39.999 95.8187 38.199 93.3202 37.399ZM90.222 73.099C90.122 73.099 89.9221 73.199 89.7222 73.199C89.3225 73.199 88.9227 72.999 88.6229 72.799L74.1312 59.099C73.9313 58.899 73.7315 58.599 73.7315 58.299L91.2214 59.499V71.699C91.2214 72.299 90.8216 72.899 90.222 73.099Z";
                    public const string OLHO_ESQUERDO_FECHADO = "M93.274 37.3668C92.574 37.167 91.774 37.0671 90.974 37.0671C88.974 37.0671 87.174 37.7665 85.974 38.8655L68.974 54.8518C68.074 55.751 67.474 56.85 67.474 57.9491C67.474 59.0482 67.974 60.1472 68.874 61.0464L85.974 77.1326C87.774 78.8311 90.674 79.4306 93.274 78.6313C95.774 77.9319 97.474 76.0335 97.474 74.0353V41.9629C97.474 39.9646 95.774 38.1661 93.274 37.3668Z";
                    public const string OLHO_ESQUERDO_ABERTO = "M85.9739 38.899L68.8739 54.899C67.9739 55.799 67.3739 56.899 67.3739 57.999C67.3739 59.099 67.8739 60.199 68.7739 61.099L85.8739 77.299C87.6739 78.999 90.5739 79.599 93.1739 78.799C95.6739 78.099 97.3739 76.199 97.3739 74.199V41.999C97.3739 39.999 95.6739 38.099 93.1739 37.399C92.4739 37.199 91.6739 37.099 90.8739 37.099C89.0739 37.099 87.1739 37.799 85.9739 38.899ZM91.1739 71.699C91.1739 72.299 90.7739 72.899 90.0739 73.099C89.9739 73.099 89.7739 73.199 89.5739 73.199C89.1739 73.199 88.7739 72.999 88.4739 72.799L74.1739 59.099C73.8739 58.799 73.7739 58.499 73.7739 58.099C73.7739 57.699 73.9739 57.399 74.1739 57.099L88.6739 43.499C89.0739 43.099 89.6739 42.999 90.2739 43.199C90.8739 43.399 91.3739 43.899 91.3739 44.599V71.699H91.1739Z";
                }

                public static class Esquerda
                {
                    public const string OLHO_ESQUERDO_ABERTO = "M50.9206 61.9L68.2106 81.8C70.0096 83.8 72.9079 84.6 75.5064 83.7C78.1049 82.8 79.8039 80.4 79.8039 77.8V38.4C79.8039 35.8 78.1049 33.4 75.5064 32.5C74.8068 32.2 74.0073 32.1 73.2078 32.1C71.3089 32.1 69.41 32.9 68.2106 34.3L50.9206 53.9C48.9218 56.2 48.9218 59.6 50.9206 61.9ZM56.1176 57L70.7092 40.3C71.109 39.8 71.8086 39.6 72.4082 39.9C73.0079 40.1 73.4076 40.7 73.4076 41.3V74.7C73.4076 75.3 73.0079 75.9 72.4082 76.1C72.2083 76.2 72.0085 76.2 71.9085 76.2C71.5087 76.2 71.009 76 70.7092 75.7L56.1176 59C55.6179 58.5 55.6179 57.6 56.1176 57Z";
                    public const string OLHO_ESQUERDO_PISCANDO = "M43.275 55.1L29.175 38.9C28.175 37.7 26.675 37.1 25.175 37.1C24.575 37.1 23.975 37.2 23.375 37.4C21.375 38.1 19.975 40 19.975 42V74.1C19.975 76.2 21.375 78 23.375 78.7C25.375 79.4 27.775 78.8 29.175 77.2L43.275 61.2C44.775 59.6 44.875 56.9 43.275 55.1ZM27.375 72.6C27.075 72.9 26.675 73.1 26.275 73.1C26.075 73.1 25.975 73.1 25.775 73C25.175 72.8 24.875 72.2 24.875 71.6V61.9L39.575 58.5C39.475 58.7 39.475 58.8 39.275 59L27.375 72.6Z";
                    public const string OLHO_ESQUERDO_FECHADO = "M75.475 32.5C74.775 32.2 73.975 32.1 73.175 32.1C71.275 32.1 69.375 32.9 68.175 34.3L50.975 53.9C48.875 56.2 48.875 59.6 50.975 62L68.275 81.9C70.075 83.9 72.975 84.7 75.575 83.8C78.175 82.9 79.875 80.5 79.875 77.9V38.5C79.775 35.7 78.075 33.4 75.475 32.5Z";

                    public const string OLHO_DIREITO_ABERTO = "M43.2251 61.3C44.8241 59.5 44.8241 56.8 43.2251 55L29.1332 38.8C28.1338 37.6 26.6347 37 25.1355 37C24.5359 37 23.9362 37.1 23.3365 37.3C21.3377 38 19.9385 39.9 19.9385 41.9V74C19.9385 76.1 21.3377 77.9 23.3365 78.6C25.3354 79.3 27.734 78.7 29.1332 77.1L43.2251 61.3ZM26.2349 73.1C26.035 73.1 25.935 73.1 25.7351 73C25.1355 72.8 24.8357 72.2 24.8357 71.6V44.4C24.8357 43.8 25.2354 43.3 25.7351 43.1C26.2349 42.9 26.9345 43 27.3342 43.5L39.2274 57.1C39.7271 57.6 39.7271 58.5 39.2274 59L27.3342 72.6C27.0344 72.9 26.6346 73.1 26.2349 73.1Z";
                    public const string OLHO_DIREITO_PISCANDO = "M75.575 32.5C74.875 32.2 74.075 32.1 73.275 32.1C71.375 32.1 69.475 32.9 68.275 34.3L50.975 53.9C48.875 56.2 48.875 59.6 50.975 62L68.275 81.9C70.075 83.9 72.975 84.7 75.575 83.8C78.175 82.9 79.875 80.5 79.875 77.9V38.5C79.775 35.8 78.075 33.4 75.575 32.5ZM72.475 76.2C72.275 76.3 72.075 76.3 71.975 76.3C71.575 76.3 71.075 76.1 70.775 75.8L56.175 59.1C55.975 58.8 55.875 58.5 55.775 58.2L73.475 60.3V74.8C73.475 75.4 73.075 76 72.475 76.2Z";
                    public const string OLHO_DIREITO_FECHADO = "M43.175 55L29.075 38.8C28.075 37.6 26.575 37 25.075 37C24.475 37 23.875 37.1 23.275 37.3C21.275 38 19.875 39.9 19.875 41.9V74C19.875 76.1 21.275 77.9 23.275 78.6C25.275 79.3 27.675 78.7 29.075 77.1L43.175 61.1C44.775 59.5 44.775 56.9 43.175 55Z";
                }

                public static class Direita
                {
                    public const string OLHO_ESQUERDO_ABERTO = "M86.775 61.3C85.175 59.5 85.175 56.8 86.775 55L100.875 38.8C101.875 37.6 103.375 37 104.875 37C105.475 37 106.075 37.1 106.675 37.3C108.675 38 110.075 39.9 110.075 41.9V74C110.075 76.1 108.675 77.9 106.675 78.6C104.675 79.3 102.275 78.7 100.875 77.1L86.775 61.3ZM103.775 73.1C103.975 73.1 104.075 73.1 104.275 73C104.875 72.8 105.175 72.2 105.175 71.6V44.4C105.175 43.8 104.775 43.3 104.275 43.1C103.775 42.9 103.075 43 102.675 43.5L90.775 57.1C90.275 57.6 90.275 58.5 90.775 59L102.675 72.6C102.975 72.9 103.375 73.1 103.775 73.1Z";
                    public const string OLHO_ESQUERDO_PISCANDO = "M86.675 55.1L100.775 38.9C101.775 37.7 103.275 37.1 104.775 37.1C105.375 37.1 105.975 37.2 106.575 37.4C108.575 38.1 109.975 40 109.975 42V74.1C109.975 76.2 108.575 78 106.575 78.7C104.575 79.4 102.175 78.8 100.775 77.2L86.675 61.2C85.175 59.6 85.075 56.9 86.675 55.1ZM102.575 72.6C102.875 72.9 103.275 73.1 103.675 73.1C103.875 73.1 103.975 73.1 104.175 73C104.775 72.8 105.075 72.2 105.075 71.6V61.9L90.375 58.5C90.475 58.7 90.475 58.8 90.675 59L102.575 72.6Z";
                    public const string OLHO_ESQUERDO_FECHADO = "M86.775 55L100.875 38.8C101.875 37.6 103.375 37 104.875 37C105.475 37 106.075 37.1 106.675 37.3C108.675 38 110.075 39.9 110.075 41.9V74C110.075 76.1 108.675 77.9 106.675 78.6C104.675 79.3 102.275 78.7 100.875 77.1L86.775 61.1C85.175 59.5 85.175 56.9 86.775 55Z";

                    public const string OLHO_DIREITO_ABERTO = "M79.075 61.9L61.775 81.8C59.975 83.8 57.075 84.6 54.475 83.7C51.875 82.8 50.175 80.4 50.175 77.8V38.4C50.175 35.8 51.875 33.4 54.475 32.5C55.175 32.2 55.975 32.1 56.775 32.1C58.675 32.1 60.575 32.9 61.775 34.3L79.075 53.9C81.075 56.2 81.075 59.6 79.075 61.9ZM73.875 57L59.275 40.3C58.875 39.8 58.175 39.6 57.575 39.9C56.975 40.1 56.575 40.7 56.575 41.3V74.7C56.575 75.3 56.975 75.9 57.575 76.1C57.775 76.2 57.975 76.2 58.075 76.2C58.475 76.2 58.975 76 59.275 75.7L73.875 59C74.375 58.5 74.375 57.6 73.875 57Z";
                    public const string OLHO_DIREITO_PISCANDO = "M54.375 32.5C55.075 32.2 55.875 32.1 56.675 32.1C58.575 32.1 60.475 32.9 61.675 34.3L78.975 53.9C81.075 56.2 81.075 59.6 78.975 62L61.675 81.9C59.875 83.9 56.975 84.7 54.375 83.8C51.775 82.9 50.075 80.5 50.075 77.9V38.5C50.175 35.8 51.875 33.4 54.375 32.5ZM57.475 76.2C57.675 76.3 57.875 76.3 57.975 76.3C58.375 76.3 58.875 76.1 59.175 75.8L73.775 59.1C73.975 58.8 74.075 58.5 74.175 58.2L56.475 60.3V74.8C56.475 75.4 56.875 76 57.475 76.2Z";
                    public const string OLHO_DIREITO_FECHADO = "M54.4749 32.5C55.1749 32.2 55.9749 32.1 56.7749 32.1C58.6749 32.1 60.5749 32.9 61.7749 34.3L78.9749 53.9C81.0749 56.2 81.0749 59.6 78.9749 62L61.6749 81.9C59.8749 83.9 56.9749 84.7 54.3749 83.8C51.7749 82.9 50.0749 80.5 50.0749 77.9V38.5C50.1749 35.7 51.8749 33.4 54.4749 32.5Z";
                }

                public static class Cima
                {
                    public const string OLHO_ESQUERDO_ABERTO = "M101.575 91.2C102.875 88.9 102.775 86.4 101.275 85L78.575 62.3C77.175 60.9 74.675 60.7 72.375 62C71.675 62.4 71.075 62.8 70.475 63.4C69.075 64.8 68.275 66.6 68.175 68.3L67.375 91.6C67.375 92.9 67.775 94 68.575 94.8C69.375 95.6 70.475 96 71.775 96L95.275 95.4C97.675 95.3 100.275 93.6 101.575 91.2ZM93.975 90.3L74.175 90.9C73.775 90.9 73.375 90.8 73.175 90.5C72.875 90.2 72.775 89.9 72.775 89.5L73.375 69.7C73.375 69.3 73.575 68.9 73.875 68.6C73.975 68.5 74.175 68.4 74.275 68.3C74.475 68.2 74.775 68.1 74.975 68.1C75.375 68.1 75.675 68.2 75.975 68.5L95.175 87.7C95.575 88.1 95.675 88.8 95.375 89.4C95.075 89.9 94.575 90.2 93.975 90.3Z";
                    public const string OLHO_ESQUERDO_PISCANDO = "M68.475 94.8C69.275 95.6 70.375 96 71.675 96L95.175 95.4C97.575 95.3 100.175 93.7 101.475 91.3C102.775 89 102.675 86.5 101.175 85.1L78.475 62.4C77.075 61 74.575 60.8 72.275 62.1C71.575 62.5 70.975 62.9 70.375 63.5C68.975 64.9 68.175 66.7 68.075 68.4L67.275 91.7C67.275 92.8 67.775 94 68.475 94.8ZM73.675 68.5C73.775 68.4 73.975 68.3 74.075 68.2C74.275 68.1 74.575 68 74.775 68C75.175 68 75.475 68.1 75.775 68.4L82.875 75.5L72.875 80.4L73.175 69.5C73.275 69.2 73.375 68.8 73.675 68.5Z";
                    public const string OLHO_ESQUERDO_FECHADO = "M68.575 94.8C69.375 95.6 70.475 96 71.775 96L95.275 95.4C97.675 95.3 100.275 93.7 101.575 91.3C102.875 89 102.775 86.5 101.275 85.1L78.475 62.3C77.075 60.9 74.575 60.7 72.275 62C71.575 62.4 70.975 62.8 70.375 63.4C68.975 64.8 68.175 66.6 68.075 68.3L67.275 91.6C67.375 92.9 67.775 94 68.575 94.8Z";

                    public const string OLHO_DIREITO_ABERTO = "M61.775 68.2C61.675 65.8 60.075 63.2 57.675 61.9C55.375 60.6 52.875 60.7 51.475 62.2L28.775 84.9C27.375 86.3 27.175 88.8 28.475 91.1C28.875 91.8 29.275 92.4 29.875 93C31.275 94.4 33.075 95.2 34.775 95.3L58.075 96.1C58.175 96.1 58.175 96.1 58.275 96.1C59.475 96.1 60.575 95.7 61.275 94.9C62.075 94.1 62.475 93 62.475 91.7L61.775 68.2ZM56.975 90.4C56.675 90.7 56.375 90.8 55.975 90.8L36.175 90.2C35.575 90.2 35.075 89.9 34.775 89.3C34.475 88.7 34.575 88 34.975 87.6L54.175 68.4C54.475 68.1 54.775 68 55.175 68C55.375 68 55.675 68.1 55.875 68.2C55.975 68.3 56.175 68.4 56.275 68.5C56.575 68.8 56.775 69.2 56.775 69.6L57.375 89.4C57.375 89.7 57.175 90.1 56.975 90.4Z";
                    public const string OLHO_DIREITO_PISCANDO = "M28.375 91.1C28.775 91.8 29.175 92.4 29.775 93C31.175 94.4 32.975 95.2 34.675 95.3L57.975 96.1C58.075 96.1 58.075 96.1 58.175 96.1C59.375 96.1 60.475 95.7 61.175 94.9C61.975 94.1 62.375 93 62.375 91.7L61.775 68.2C61.675 65.8 60.075 63.2 57.675 61.9C55.375 60.6 52.875 60.7 51.475 62.2L28.775 84.9C27.275 86.3 27.175 88.8 28.375 91.1ZM54.075 68.3C54.375 68 54.675 67.9 55.075 67.9C55.275 67.9 55.575 68 55.775 68.1C55.875 68.2 56.075 68.3 56.175 68.4C56.475 68.7 56.675 69.1 56.675 69.5L56.975 80.4L46.875 75.6L54.075 68.3Z";
                    public const string OLHO_DIREITO_FECHADO = "M28.375 91.2C28.775 91.9 29.175 92.5 29.775 93.1C31.175 94.5 32.975 95.3 34.675 95.4L57.975 96.1C58.075 96.1 58.075 96.1 58.175 96.1C59.375 96.1 60.475 95.7 61.175 94.9C61.975 94.1 62.375 93 62.375 91.7L61.775 68.2C61.675 65.8 60.075 63.2 57.675 61.9C55.375 60.6 52.875 60.7 51.475 62.2L28.775 84.9C27.275 86.4 27.175 88.9 28.375 91.2Z";
                }

                public static class Baixo
                {
                    public const string OLHO_ESQUERDO_ABERTO = "M68.25 47.9C68.35 50.3 69.95 52.9 72.35 54.2C74.65 55.5 77.15 55.4 78.55 53.9L101.25 31.2C102.65 29.8 102.85 27.3 101.55 25C101.15 24.3 100.75 23.7 100.15 23.1C98.75 21.7 96.95 20.9 95.25 20.8L71.95 20C71.85 20 71.85 20 71.75 20C70.55 20 69.45 20.4 68.75 21.2C67.95 22 67.55 23.1 67.55 24.4L68.25 47.9ZM73.05 25.7C73.35 25.4 73.65 25.3 74.05 25.3L93.85 25.9C94.45 25.9 94.95 26.2 95.25 26.8C95.55 27.4 95.45 28.1 95.05 28.5L75.85 47.7C75.55 48 75.25 48.1 74.85 48.1C74.65 48.1 74.35 48 74.15 47.9C74.05 47.8 73.85 47.7 73.75 47.6C73.45 47.3 73.25 46.9 73.25 46.5L72.65 26.7C72.65 26.4 72.85 26 73.05 25.7Z";
                    public const string OLHO_ESQUERDO_PISCANDO = "M101.575 25C101.175 24.3 100.775 23.7 100.175 23.1C98.775 21.7 96.975 20.9 95.275 20.8L71.975 20C71.875 20 71.875 20 71.775 20C70.575 20 69.475 20.4 68.775 21.2C67.975 22 67.575 23.1 67.575 24.4L68.1749 47.9C68.2749 50.3 69.875 52.9 72.275 54.2C74.575 55.5 77.075 55.4 78.475 53.9L101.175 31.2C102.675 29.8 102.775 27.3 101.575 25ZM75.875 47.8C75.575 48.1 75.275 48.2 74.875 48.2C74.675 48.2 74.3749 48.1 74.1749 48C74.0749 47.9 73.875 47.8 73.775 47.7C73.475 47.4 73.275 47 73.275 46.6L72.975 35.7L83.075 40.5L75.875 47.8Z";
                    public const string OLHO_ESQUERDO_FECHADO = "M101.575 24.9C101.175 24.2 100.775 23.6 100.175 23C98.775 21.6 96.975 20.8 95.275 20.7L71.975 20C71.875 20 71.875 20 71.775 20C70.575 20 69.475 20.4 68.775 21.2C67.975 22 67.575 23.1 67.575 24.4L68.175 47.9C68.275 50.3 69.875 52.9 72.275 54.2C74.575 55.5 77.075 55.4 78.475 53.9L101.175 31.2C102.675 29.7 102.775 27.2 101.575 24.9Z";

                    public const string OLHO_DIREITO_ABERTO = "M28.45 24.9C27.15 27.2 27.25 29.7 28.75 31.1L51.45 53.8C52.85 55.2 55.35 55.4 57.65 54.1C58.35 53.7 58.95 53.3 59.55 52.7C60.95 51.3 61.75 49.5 61.85 47.8L62.65 24.5C62.65 23.2 62.25 22.1 61.45 21.3C60.65 20.5 59.55 20.1 58.25 20.1L34.75 20.7C32.35 20.8 29.75 22.5 28.45 24.9ZM36.05 25.8L55.85 25.2C56.25 25.2 56.65 25.3 56.85 25.6C57.15 25.9 57.25 26.2 57.25 26.6L56.65 46.4C56.65 46.8 56.45 47.2 56.15 47.5C56.05 47.6 55.85 47.7 55.75 47.8C55.55 47.9 55.25 48 55.05 48C54.65 48 54.35 47.9 54.05 47.6L34.85 28.4C34.45 28 34.35 27.3 34.65 26.7C34.95 26.2 35.45 25.9 36.05 25.8Z";
                    public const string OLHO_DIREITO_PISCANDO = "M61.4749 21.3C60.6749 20.5 59.5749 20.1 58.2749 20.1L34.7749 20.7C32.3749 20.8 29.7749 22.4 28.4749 24.8C27.1749 27.1 27.2749 29.6 28.7749 31L51.4749 53.7C52.8749 55.1 55.3749 55.3 57.6749 54C58.3749 53.6 58.9749 53.2 59.5749 52.6C60.9749 51.2 61.7749 49.4 61.8749 47.7L62.6749 24.4C62.6749 23.3 62.1749 22.1 61.4749 21.3ZM56.2749 47.6C56.1749 47.7 55.9749 47.8 55.8749 47.9C55.6749 48 55.3749 48.1 55.1749 48.1C54.7749 48.1 54.4749 48 54.1749 47.7L47.0749 40.6L57.0749 35.7L56.7749 46.6C56.6749 46.9 56.5749 47.3 56.2749 47.6Z";
                    public const string OLHO_DIREITO_FECHADO = "M61.375 21.3C60.575 20.5 59.475 20.1 58.175 20.1L34.675 20.7C32.275 20.8 29.675 22.4 28.375 24.8C27.075 27.1 27.175 29.6 28.675 31L51.475 53.8C52.875 55.2 55.375 55.4 57.675 54.1C58.375 53.7 58.975 53.3 59.575 52.7C60.975 51.3 61.775 49.5 61.875 47.8L62.675 24.5C62.575 23.2 62.175 22.1 61.375 21.3Z";
                }
            }

            public static class Mapa
            {
                public const string CONTORNO = "Images.Mapa.svg";
            }
        }
    }
}
