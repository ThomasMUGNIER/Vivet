PGDMP         2                 z            Vivet DB    14.1    14.1                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16394    Vivet DB    DATABASE     o   CREATE DATABASE "Vivet DB" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_United Kingdom.1252';
    DROP DATABASE "Vivet DB";
                postgres    false            �            1259    16400    CAMION    TABLE     }   CREATE TABLE public."CAMION" (
    "NoMatricule" bigint NOT NULL,
    "NomProprietaire" name COLLATE pg_catalog."default"
);
    DROP TABLE public."CAMION";
       public         heap    postgres    false            �            1259    16415 
   LIMITATION    TABLE     y   CREATE TABLE public."LIMITATION" (
    "CapaciteMax" bigint,
    "CodeType" bigint,
    "NoMatricule" bigint NOT NULL
);
     DROP TABLE public."LIMITATION";
       public         heap    postgres    false            �            1259    16465    PESEE    TABLE       CREATE TABLE public."PESEE" (
    "Codebordeaupesee" bigint NOT NULL,
    "Poidsarrivée" bigint,
    "Poidsdépart" bigint,
    "Heure" time with time zone,
    "CodeType" bigint,
    "Datepesee" date,
    "NoMatricule" bigint,
    "CodeSyndicat" bigint
);
    DROP TABLE public."PESEE";
       public         heap    postgres    false            �            1259    16452    SYNDICAT    TABLE     �   CREATE TABLE public."SYNDICAT" (
    "CodeSyndicat" bigint NOT NULL,
    "NomSyndicat" name,
    "AdresseSyndicat" name,
    "TelSyndicat" integer
);
    DROP TABLE public."SYNDICAT";
       public         heap    postgres    false            �            1259    16405    TYPE_DECHET    TABLE     ^   CREATE TABLE public."TYPE_DECHET" (
    "CodeType" bigint NOT NULL,
    "LibelleType" name
);
 !   DROP TABLE public."TYPE_DECHET";
       public         heap    postgres    false                      0    16400    CAMION 
   TABLE DATA           D   COPY public."CAMION" ("NoMatricule", "NomProprietaire") FROM stdin;
    public          postgres    false    209   �                 0    16415 
   LIMITATION 
   TABLE DATA           P   COPY public."LIMITATION" ("CapaciteMax", "CodeType", "NoMatricule") FROM stdin;
    public          postgres    false    211   a       	          0    16465    PESEE 
   TABLE DATA           �   COPY public."PESEE" ("Codebordeaupesee", "Poidsarrivée", "Poidsdépart", "Heure", "CodeType", "Datepesee", "NoMatricule", "CodeSyndicat") FROM stdin;
    public          postgres    false    213   �                 0    16452    SYNDICAT 
   TABLE DATA           e   COPY public."SYNDICAT" ("CodeSyndicat", "NomSyndicat", "AdresseSyndicat", "TelSyndicat") FROM stdin;
    public          postgres    false    212   �                 0    16405    TYPE_DECHET 
   TABLE DATA           B   COPY public."TYPE_DECHET" ("CodeType", "LibelleType") FROM stdin;
    public          postgres    false    210   3       l           2606    16436    CAMION CAMION_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public."CAMION"
    ADD CONSTRAINT "CAMION_pkey" PRIMARY KEY ("NoMatricule");
 @   ALTER TABLE ONLY public."CAMION" DROP CONSTRAINT "CAMION_pkey";
       public            postgres    false    209            p           2606    16434    LIMITATION LIMITATION_pkey 
   CONSTRAINT     g   ALTER TABLE ONLY public."LIMITATION"
    ADD CONSTRAINT "LIMITATION_pkey" PRIMARY KEY ("NoMatricule");
 H   ALTER TABLE ONLY public."LIMITATION" DROP CONSTRAINT "LIMITATION_pkey";
       public            postgres    false    211            t           2606    16469    PESEE PESEE_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public."PESEE"
    ADD CONSTRAINT "PESEE_pkey" PRIMARY KEY ("Codebordeaupesee");
 >   ALTER TABLE ONLY public."PESEE" DROP CONSTRAINT "PESEE_pkey";
       public            postgres    false    213            r           2606    16456    SYNDICAT SYNDICAT_pkey 
   CONSTRAINT     d   ALTER TABLE ONLY public."SYNDICAT"
    ADD CONSTRAINT "SYNDICAT_pkey" PRIMARY KEY ("CodeSyndicat");
 D   ALTER TABLE ONLY public."SYNDICAT" DROP CONSTRAINT "SYNDICAT_pkey";
       public            postgres    false    212            n           2606    16462    TYPE_DECHET TYPE_DECHET_pkey 
   CONSTRAINT     f   ALTER TABLE ONLY public."TYPE_DECHET"
    ADD CONSTRAINT "TYPE_DECHET_pkey" PRIMARY KEY ("CodeType");
 J   ALTER TABLE ONLY public."TYPE_DECHET" DROP CONSTRAINT "TYPE_DECHET_pkey";
       public            postgres    false    210            x           2606    16475    PESEE CodeSyndicat    FK CONSTRAINT     �   ALTER TABLE ONLY public."PESEE"
    ADD CONSTRAINT "CodeSyndicat" FOREIGN KEY ("CodeSyndicat") REFERENCES public."SYNDICAT"("CodeSyndicat") NOT VALID;
 @   ALTER TABLE ONLY public."PESEE" DROP CONSTRAINT "CodeSyndicat";
       public          postgres    false    213    3186    212            w           2606    16470    PESEE CodeType    FK CONSTRAINT     �   ALTER TABLE ONLY public."PESEE"
    ADD CONSTRAINT "CodeType" FOREIGN KEY ("CodeType") REFERENCES public."TYPE_DECHET"("CodeType") NOT VALID;
 <   ALTER TABLE ONLY public."PESEE" DROP CONSTRAINT "CodeType";
       public          postgres    false    213    3182    210            u           2606    16485    LIMITATION CodeType    FK CONSTRAINT     �   ALTER TABLE ONLY public."LIMITATION"
    ADD CONSTRAINT "CodeType" FOREIGN KEY ("CodeType") REFERENCES public."TYPE_DECHET"("CodeType") NOT VALID;
 A   ALTER TABLE ONLY public."LIMITATION" DROP CONSTRAINT "CodeType";
       public          postgres    false    3182    210    211            y           2606    16480    PESEE NoMatricule    FK CONSTRAINT     �   ALTER TABLE ONLY public."PESEE"
    ADD CONSTRAINT "NoMatricule" FOREIGN KEY ("NoMatricule") REFERENCES public."CAMION"("NoMatricule") NOT VALID;
 ?   ALTER TABLE ONLY public."PESEE" DROP CONSTRAINT "NoMatricule";
       public          postgres    false    213    3180    209            v           2606    16490    LIMITATION NoMatricule    FK CONSTRAINT     �   ALTER TABLE ONLY public."LIMITATION"
    ADD CONSTRAINT "NoMatricule" FOREIGN KEY ("NoMatricule") REFERENCES public."CAMION"("NoMatricule") NOT VALID;
 D   ALTER TABLE ONLY public."LIMITATION" DROP CONSTRAINT "NoMatricule";
       public          postgres    false    211    209    3180               �   x���
�0�ϳ#M��Q��(bO����	�D�O��23�|��d9����zˋe�C���@��K2�AG���h�4�~�T��7�{�R��7����sOR{�J�5��_2���+M��I�T�k�l�3gˁԈ�Nຒ��|?vD�$�0W         W   x�%���@�jy� ���d�9�� 2Y8�����{����T:�|`�'�|a�7�����|��Yĭ�N�q��m�M�����      	   �  x�m�Qr�0D��U:�@��C���9
r�yg<���]��d���O�'���
�>�\����V�ڠ��p�v �ωW�P�{!�`����D`%m�%�
�Fc��2X أǾ� �1�,�0 ��02�rL��Q����P�3~��.�A�)��+38�<�89��V��w�}�]7�.ȃ���2��I{K}rH�A{�|r@h����W8�T&��	_�i0����%���y�8��� ]�_\�t9*Ϋ�@��M�r"��\GOl�R}xOQzA���KF+~�1���D���Ƕp(j��D
ш�^I �_i�:c��v��HE�u7�,��;��G,ƖV��Ĵ�&����N��D
<��{]�	�D�u��+L9^��T��g��%����^n=[d��^�/27�.�Q�GPM��y�n��»k�         �   x�u�;!@��s��B����2���8	�o�<�s5���}��$������|k���b�N%�2�.vK�������wN9���9O�Bw����c�4�5�"'���_�q�h�8��V�R�o�7�         4   x�3�t�2���2�t�2��2��2�朾\�\���\��Q\1z\\\ ��     