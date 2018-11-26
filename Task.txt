Note :
1. Koneksi antara aplikasi dan database melalui ODBC MySql (DSN).
Apabila tidak menggunakan DSN harap memberitahukan kenapa tidak menggunakan DSN.
2. Untuk variabel static diharapkan menggunakan app.config.
3. Gunakan NetFramework 4.6.1.
4. Fitur-fitur yang harus ada di aplikasi dekstop
    a. Eksport database
	b. Report dari database (Pdf dan SpreadSheet) -> Highest Priority #1
	c. User Management :
		c.1 CRUD User
		c.2 User Privilege : Admin, Instruktur, Operator, CommonUser, Executive
	d. File Management : 
		d.1 Menyimpan data (file / folder) ke server (upload).
		d.2 Mengambil data dari server (download).
		d.3 Data Versioning.
	e. Security dan Enskripsi releated dengan file dan user management.
		e.1 Enkrip/Dekrip data yang akan disimpan di server.
		e.2 Enkrip/Dekrip pada saat user login.
		e.3 Hak akses terhadap data sesuai dengan privilege user.
	f. Menggunakan bahasa pemrograman C#
5. Fitur-fitur yang harus ada di web dashboard
	a. Menghilangkan semua tulisan 'Grafana' menjadi 'Inviris-Dashboard' -> Highest Priority #2
	b. Buat grafik berdasarkan data yang ada didatabase (data realtime tetapi mengambil data waktu yang ada di db).
	c. Buat dokumentasi dalam melakukan customisasi di web dashboard.
6. Server menggunakan CentOS 7