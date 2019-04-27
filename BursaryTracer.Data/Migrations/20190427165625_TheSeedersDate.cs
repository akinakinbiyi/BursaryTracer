using Microsoft.EntityFrameworkCore.Migrations;

namespace BursaryTracer.Data.Migrations
{
    public partial class TheSeedersDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Faculties_FacultyId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Schools_SchoolId",
                table: "Faculties");

            migrationBuilder.RenameColumn(
                name: "Acronym",
                table: "Schools",
                newName: "Abbreviation");

            migrationBuilder.RenameColumn(
                name: "ToYear",
                table: "Governors",
                newName: "StartsTenure");

            migrationBuilder.RenameColumn(
                name: "FromYear",
                table: "Governors",
                newName: "EndsTenure");

            migrationBuilder.AddColumn<int>(
                name: "StateId",
                table: "Schools",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "Faculties",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "FacultyId",
                table: "Courses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "CourseId", "Name", "SchoolId" },
                values: new object[,]
                {
                    { 1, 0, "Faculty of Agriculture", null },
                    { 12, 0, "Faculty of Pharmaceutical Sciences", null },
                    { 11, 0, "Faculty of Biological Sciences", null },
                    { 9, 0, "Faculty of Law", null },
                    { 8, 0, "Faculty of Science and Technology", null },
                    { 7, 0, "Faculty of Engineering", null },
                    { 10, 0, "Faculty of Veterinary Medicine", null },
                    { 5, 0, "Faculty of Education", null },
                    { 4, 0, "Faculty of Business Administration", null },
                    { 3, 0, "Faculty of Medical Sciences", null },
                    { 2, 0, "Faculty of Arts", null },
                    { 6, 0, "Faculty of Social Sciences", null }
                });

            migrationBuilder.InsertData(
                table: "Governors",
                columns: new[] { "Id", "EndsTenure", "Name", "StartsTenure", "StateId" },
                values: new object[,]
                {
                    { 100, "11-May", "Aliyu Doma", "29-May-07", 25 },
                    { 95, "Incumbent", "Abdulfatah Ahmed", "29-May-11", 23 },
                    { 96, "29-May-07", "Mr Bola Tinubu", "29-May-99", 24 },
                    { 97, "29-May-15", "Mr Babatunde Fashola", "29-May-07", 24 },
                    { 98, "", "Mr Akinwunmi Ambode", "29-May-15", 24 },
                    { 99, "29-May-07", "Abdullahi Adamu", "29-May-99", 25 },
                    { 101, "", "Umaru Tanko Al-Makura", "11-May", 25 },
                    { 107, "Incumbent", "Ibikunle Amosun", "29-May-11", 27 },
                    { 103, "29-May-15", "Mu'azu Babangida Aliyu", "29-May-07", 26 },
                    { 104, "-", "Abubakar Sani Bello", "29-May-15", 26 },
                    { 105, "29-May-03", "Olusegun Osoba", "29-May-99", 27 },
                    { 106, "11-May", "Gbenga Daniel", "29-May-03", 27 },
                    { 94, "29-May-11", "Bukola Saraki", "29-May-03", 23 },
                    { 108, "2003-05", "Adebayo Adefarati", "1999-05", 28 },
                    { 102, "29-May-07", "Abdulkadir Kure", "29-May-99", 26 },
                    { 93, "29-May-03", "Mohammed Lawal", "29-May-99", 23 },
                    { 87, "29-May-03", "Abubakar Audu", "29-May-99", 22 },
                    { 91, "", "Idris Wada", "12-Jan", 22 },
                    { 76, "11-May", "Malam�Ibrahim Shekarau", "3-May", 19 },
                    { 77, "15-May", "Engineer (Dr.) Rabiu Musa Kwankwaso", "11-May", 19 },
                    { 78, "incumbent", "Abdullahi Umar Ganduje", "15-May", 19 },
                    { 79, "29-May-07", "Umaru Musa Yar'Adua", "29-May-99", 20 },
                    { 80, "29-May-15", "Ibrahim Shema", "29-May-07", 20 },
                    { 81, "Incumbent", "Aminu Bello Masari", "29-May-15", 20 },
                    { 82, "29-May-07", "Adamu Aliero", "29-May-99", 21 },
                    { 83, "24-Feb-12", "Usman Saidu Nasamu Dakingari", "29-May-07", 21 },
                    { 84, "2-Apr-12", "Aminu Musa Habib Jega", "24-Feb-12", 21 },
                    { 85, "29-May-15", "Usman Saidu Nasamu Dakingari", "2-Apr-12", 21 },
                    { 86, "Incumbent", "Abubakar Atiku Bagudu", "29-May-15", 21 },
                    { 109, "2009-02", "Olusegun Agagu", "2003-05", 28 },
                    { 88, "6-Feb-08", "Ibrahim Idris", "29-May-03", 22 },
                    { 89, "29-Mar-08", "Clarence Olafemi", "6-Feb-08", 22 },
                    { 90, "11-Jan", "Ibrahim Idris", "29-Mar-08", 22 },
                    { 92, "Incumbent", "Alhaji Yahaya Adoza Bello", "27-Jan-16", 22 },
                    { 110, "2017-02", "Olusegun Mimiko", "2009-02", 28 },
                    { 117, "28-May-07", "Rashidi Adewolu Ladoja", "29-May-03", 30 },
                    { 112, "29-May-03", "Adebisi Akande", "29-May-99", 29 },
                    { 133, "11-Apr-08", "Aliyu Magatakarda Wamakko", "29-May-07", 33 },
                    { 134, "29-May-08", "Abdullahi Balarabe Salame", "11-Apr-08", 33 },
                    { 135, "29-May-15", "Aliyu Magatakarda Wamakko", "29-May-08", 33 },
                    { 136, "Incumbent", "Aminu Waziri Tambuwal", "28-May-15", 33 },
                    { 137, "29-May-07", "Jolly Nyame", "29-May-99", 34 },
                    { 138, "12-Oct", "Danbaba Danfulani Suntai", "29-May-07", 34 },
                    { 139, "2013", "Garba Umar", "12-Oct", 34 },
                    { 140, "29-May-15", "Abubakar sani danladi", "2013", 34 },
                    { 141, "Incumbent", "Darius Dickson Ishaku", "29-May-15", 34 },
                    { 142, "29-May-07", "Bukar Abba Ibrahim", "29-May-99", 35 },
                    { 143, "27-Jan-09", "Mamman Bello Ali", "29-May-07", 35 },
                    { 144, "present", "Ibrahim Gaidam", "2009", 35 },
                    { 145, "29-May-07", "Ahmad Sani Yarima", "29-May-99", 36 },
                    { 146, "11-May", "Mahmud Shinkafi", "29-May-07", 36 },
                    { 147, "incumbent", "Abdul'aziz Abubakar Yari", "11-May", 36 },
                    { 132, "29-May-07", "Attahiru Bafarawa", "29-May-99", 33 },
                    { 111, "Incumbent", "Oluwarotimi Odunayo Akeredolu", "2017-02", 28 },
                    { 131, "Incumbent", "Ezenwo Wike", "29-May-15", 32 },
                    { 129, "26-Oct-07", "Celestine Omehia", "29-May-07", 32 },
                    { 113, "26-Nov-10", "Olagunsoye Oyinlola", "29-May-03", 29 },
                    { 114, "26-Nov-18", "Rauf Aregbesola", "26-Nov-10", 29 },
                    { 116, "28-May-03", "Dr.�Lam Adesina", "29-May-99", 30 },
                    { 75, "3-May", "Engineer (Dr.)�Rabiu Musa Kwankwaso", "May-99", 19 },
                    { 118, "7-Dec-06", "Christopher Alao-Akala", "12-Jan-06", 30 },
                    { 119, "11-May", "Christopher Alao-Akala", "29-May-07", 30 },
                    { 120, "Incumbent", "Abiola Ajimobi", "11-May", 30 },
                    { 121, "18-May-04", "Joshua Dariye", "29-May-99", 31 },
                    { 122, "18-Nov-04", "Chris Alli", "18-May-04", 31 },
                    { 123, "13-Nov-06", "Joshua Dariye", "18-Nov-04", 31 },
                    { 124, "27-Apr-07", "Michael Botmang", "13-Nov-06", 31 },
                    { 125, "29-May-07", "Joshua Dariye", "27-Apr-07", 31 },
                    { 126, "29-May-15", "Jonah David Jang", "29-May-07", 31 },
                    { 127, "Incumbent", "Simon Bako Lalong", "29-May-15", 31 },
                    { 128, "29-May-07", "Peter Odili", "29-May-99", 32 },
                    { 130, "29-May-15", "Chibuike Amaechi", "26-Oct-07", 32 },
                    { 74, "Incumbent", "Nasiru Ahmed El-Rufai", "29-May-15", 18 },
                    { 115, "Incumbent", "Adegboyega Oyetola", "26-Nov-18", 29 },
                    { 72, "15-Dec-12", "Patrick Ibrahim Yakowa", "20-May-10", 18 },
                    { 20, "29-May-07", "Ahmad Adamu Mu'azu", "29-May-99", 5 },
                    { 21, "29-May-20", "Malam Isa Yuguda", "29-May-07", 5 },
                    { 22, "Incumbent", "Barrister M. A. ABUBAKAR", "29-May-15", 5 },
                    { 23, "9-Dec-05", "Diepreye Alamieyeseigha", "29-May-99", 6 },
                    { 24, "29-May-07", "Goodluck Jonathan", "9-Dec-05", 6 },
                    { 25, "16-Apr-08", "Timipre Sylva", "29-May-07", 6 },
                    { 19, "Incumbent", "Willie Obiano", "17-Mar-14", 4 },
                    { 26, "27-May-08", "Werinipre Seibarugo", "16-Apr-08", 6 },
                    { 28, "14-Feb-12", "Nestor Binabo", "27-Jan-12", 6 },
                    { 29, "Present", "Henry Dickson", "14-Feb-12", 6 },
                    { 30, "29-May-07", "George Akume", "29-May-99", 7 },
                    { 31, "29-May-15", "Gabriel Suswam", "29-May-07", 7 },
                    { 73, "29-May-15", "Mukhtar Ramalan Yero", "15-Dec-12", 18 },
                    { 33, "29-May-03", "Mala Kachalla", "29-May-99", 8 },
                    { 27, "27-Jan-12", "Timipre Sylva", "27-May-08", 6 },
                    { 18, "17-Mar-14", "Peter Obi", "9-Feb-07", 4 },
                    { 17, "9-Feb-07", "Virginia Etiaba", "3-Nov-06", 4 },
                    { 16, "3-Nov-06", "Peter Obi", "17-Mar-06", 4 },
                    { 1, "29-May-07", "Orji Uzor Kalu", "29-May-99", 1 },
                    { 2, "29-May-15", "Theodore A. Orji", "29-May-07", 1 },
                    { 3, "Incumbent", "Okezie Ikpeazu", "29-May-15", 1 },
                    { 4, "29-May-07", "Boni Haruna", "29-May-99", 2 },
                    { 5, "26-Feb-08", "Murtala Nyako", "29-May-07", 2 },
                    { 6, "29-Apr-08", "James Shaibu Barka", "26-Feb-08", 2 },
                    { 7, "15-Jul-14", "Murtala Nyako", "29-Apr-08", 2 },
                    { 8, "1-Oct-14", "Alhaji Ahmadu�Umaru Fintiri", "15-Jul-14", 2 },
                    { 9, "29-May-15", "Bala James Ngilari", "1-Oct-14", 2 },
                    { 10, "Incumbent", "Bindo Jibrilla", "29-May-15", 2 },
                    { 11, "29-May-07", "Victor Attah", "29-May-99", 3 },
                    { 12, "29-May-15", "Godswill Akpabio", "29-May-07", 3 },
                    { 13, "Incumbent", "Udom Gabriel Emmanuel", "29-May-15", 3 },
                    { 14, "29-May-03", "Chinwoke Mbadinuju", "29-May-99", 4 },
                    { 15, "17-Mar-06", "Chris Ngige", "29-May-03", 4 },
                    { 34, "29-May-11", "Ali Modu Sheriff", "29-May-03", 8 },
                    { 35, "Incumbent", "Kashim Shettima", "29-May-11", 8 },
                    { 32, "Incumbent", "Samuel Ortom", "29-May-15", 7 },
                    { 37, "29-May-15", "Liyel Imoke", "29-May-07", 9 },
                    { 57, "Till Date", "Dr. Kayode Fayemi", "16th Oct 2018", 13 },
                    { 36, "29-May-07", "Donald Duke", "29-May-99", 9 },
                    { 59, "29-May-15", "Sullivan Chime", "29-May-07", 14 },
                    { 60, "Incumbent", "Ifeanyi Ugwuanyi", "29-May-15", 14 },
                    { 61, "29-May-03", "Abubakar Habu Hashidu", "29-May-99", 15 },
                    { 62, "11-May", "Mohammed Danjuma Goje", "29-May-03", 15 },
                    { 63, "Incumbent", "Ibrahim Hassan Dankwambo", "11-May", 15 },
                    { 64, "29-May-07", "Achike Udenwa", "29-May-99", 16 },
                    { 65, "29-May-11", "Ikedi G. Ohakim", "29-May-07", 16 },
                    { 66, "Incumbent", "Owelle Rochas Anayo Okorocha", "29-May-11", 16 },
                    { 67, "29-May-07", "Ibrahim Saminu Turaki", "29-May-99", 17 },
                    { 68, "29-May-15", "Sule Lamido", "29-May-07", 17 },
                    { 69, "Incumbent", "Badaru Abubakar", "29-May-15", 17 },
                    { 70, "29-May-07", "Ahmed Makarfi", "29-May-99", 18 },
                    { 71, "19-May-10", "Mohammed Namadi Sambo", "29-May-07", 18 },
                    { 56, "16th Oct 2018", "Ayo Fayose", "16th Oct 2014", 13 },
                    { 55, "16th Oct 2014", "Dr. Kayode Fayemi", "15th Oct 2010", 13 },
                    { 58, "29-May-07", "Chimaroke Nnamani", "29-May-99", 14 },
                    { 53, "29-May-07", "Tope Ademiluyi", "27-Apr-07", 13 },
                    { 38, "Incumbent", "Benedict Ayade", "29-May-15", 9 },
                    { 39, "29-May-07", "James Ibori", "29-May-99", 10 },
                    { 40, "29-May-15", "Emmanuel Uduaghan", "29-May-07", 10 },
                    { 54, "15-Oct-10", "Segun Oni", "29-May-07", 13 },
                    { 42, "29-May-07", "Sam Egwu", "29-May-99", 11 },
                    { 43, "29-May-15", "Martin Elechi", "29-May-07", 11 },
                    { 44, "Incumbent", "Dave Umahi", "29-May-15", 11 },
                    { 41, "Incumbent", "Ifeanyi Okowa", "29-May-15", 10 },
                    { 46, "12-Nov-08", "Professor Oserheimen Osunbor", "29-May-07", 12 },
                    { 47, "12-Nov-16", "Comrade Adams A. Oshiomhole", "12-Nov-08", 12 },
                    { 48, "Incumbent", "Godwin Obaseki", "12-Nov-16", 12 },
                    { 49, "29-May-03", "Otunba Niyi Adebayo", "29-May-99", 13 },
                    { 50, "16-Oct-06", "Ayo Fayose", "29-May-03", 13 },
                    { 51, "18-Oct-06", "Chief Friday Aderemi", "17-Oct-06", 13 },
                    { 52, "27-Apr-07", "Tunji Olurin", "18-Oct-06", 13 },
                    { 45, "29-May-07", "Chief Lucky Igbinedion", "29-May-99", 12 }
                });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Abbreviation", "Name", "StateId" },
                values: new object[] { "ABSU", "Abia State University", 1 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Abbreviation", "Name", "StateId" },
                values: new object[] { "", "Gregory University", 1 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Abbreviation", "Name", "StateId" },
                values: new object[] { "AUN", "American University of Nigeria", 2 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Abbreviation", "Name", "StateId" },
                values: new object[] { "ADSU", "Adamawa State University", 2 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Abbreviation", "Name", "StateId" },
                values: new object[] { "AKSU", "Akwa Ibom State University", 3 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Abbreviation", "Name", "SchoolCategoryId", "StateId" },
                values: new object[] { "ANSU", "Anambra State University", 3, 4 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Abbreviation", "Name", "SchoolCategoryId", "StateId" },
                values: new object[] { "ATBU", "Abubakar Tafawa Balewa University", 3, 5 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Abbreviation", "Name", "SchoolCategoryId", "StateId" },
                values: new object[] { "BSU", "Benue State University", 3, 7 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Abbreviation", "Name", "SchoolCategoryId", "StateId" },
                values: new object[] { "CRUTECH", "Cross River University of Technology", 3, 9 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Abbreviation", "Name", "SchoolCategoryId", "StateId" },
                values: new object[] { "UNICAL", "University of Calabar", 3, 9 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Abbreviation", "Name", "SchoolCategoryId", "StateId" },
                values: new object[] { "DELSU", "Delta State University, Abraka", 3, 10 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Abbreviation", "Name", "SchoolCategoryId", "StateId" },
                values: new object[,]
                {
                    { 180, "", "Abdul Gusau Polytechnic", 2, 36 },
                    { 120, "", "College of Agriculture, Zuru", 2, 21 },
                    { 121, "", "Federal Polytechnic, Birnin-Kebbi", 2, 21 },
                    { 122, "", "Kebbi State Polytechnic", 2, 21 },
                    { 123, "", "College of Agriculture, Kabba", 2, 22 },
                    { 124, "", "Federal Polytechnic, Idah", 2, 22 },
                    { 125, "", "Kogi State Polytechnic", 2, 22 },
                    { 126, "", "Federal Polytechnic, Offa", 2, 23 },
                    { 127, "", "Kwara State Polytechnic", 2, 23 },
                    { 128, "", "Federal College of Fisheries and Marine Technology", 2, 24 },
                    { 129, "", "Grace Polytechnic", 2, 24 },
                    { 130, "", "Lagos City Polytechnic", 2, 24 },
                    { 131, "", "Lagos State Polytechnic", 2, 24 },
                    { 132, "", "Ronik Polytechnic", 2, 24 },
                    { 133, "", "School of Agriculture, Ikorodu", 2, 24 },
                    { 134, "", "Wavecrest College of Hospitality", 2, 24 },
                    { 135, "", "Wolex Polytechnic", 2, 24 },
                    { 136, "", "Yaba College of Technology", 2, 24 },
                    { 119, "", "Hassan Usman Katsina Polytechnic", 2, 20 },
                    { 137, "", "College of Agriculture, Lafia", 2, 25 },
                    { 118, "", "Mohammed Abdullahi Wase Polytechnic", 2, 19 },
                    { 116, "", "Audu Bako School of Agriculture", 2, 19 },
                    { 99, "", "Institute of Management Technology, Enugu", 2, 14 },
                    { 100, "", "Our Saviour Institute of Science and Technology", 2, 14 },
                    { 101, "", "Federal College of Land Resources Technology, Owerri", 2, 16 },
                    { 102, "", "Federal Polytechnic, Nekede", 2, 16 },
                    { 103, "", "Temple Gate Polytechnic", 2, 1 },
                    { 104, "", "Imo State Polytechnic", 2, 16 },
                    { 105, "", "Imo State Technological Skills Acquisition Center", 2, 16 },
                    { 106, "", "Hussaini Adamu Federal Polytechnic", 2, 17 },
                    { 107, "", "Hussani Adamu Polytechnic", 2, 17 },
                    { 108, "", "College of Agriculture and Animal Science", 2, 18 },
                    { 109, "", "Federal College of Chemical and Leather and Technology", 2, 18 },
                    { 110, "", "Federal College of Forestry Mechanisation", 2, 18 },
                    { 111, "", "Kaduna Polytechnic", 2, 18 },
                    { 112, "", "Nigerian College of Aviation Technology", 2, 18 },
                    { 113, "", "federal school of statistics Manchok", 2, 18 },
                    { 114, "", "Nuhu Bamalli Polytechnic", 2, 18 },
                    { 115, "", "Samaru College of Agriculture", 2, 18 },
                    { 117, "", "Kano State Polytechnic", 2, 19 },
                    { 138, "", "Maurid Institute of Management & Technology, Nasarawa", 2, 25 },
                    { 139, "", "Federal Polytechnic, Nassarawa", 2, 25 },
                    { 140, "", "Nasarawa State Polytechnic", 2, 25 },
                    { 163, "", "Federal College of Forestry, Ibadan", 2, 30 },
                    { 164, "", "The Polytechnic, Ibadan", 2, 30 },
                    { 165, "", "The Kings Poly, Shaki, Oyo", 2, 30 },
                    { 166, "", "Tower Polytechnic, Ibadan", 2, 30 },
                    { 167, "", "The Oke-Ogun Polytechnic, Saki", 2, 30 },
                    { 168, "", "Federal College of Animal Health and Production Technology, Vom", 2, 31 },
                    { 169, "", "Federal College of Education, Pankshin", 2, 31 },
                    { 170, "", "Federal College of Forestry. Jos", 2, 31 },
                    { 171, "", "Federal College of Land Resources Technology, Kuru", 2, 31 },
                    { 172, "", "Plateau State College of Agriculture", 2, 31 },
                    { 173, "", "Plateau State Polytechnic", 2, 31 },
                    { 174, "", "Eastern Polytechnic", 2, 32 },
                    { 175, "", "Port Harcourt Polytechnic", 2, 32 },
                    { 176, "", "Rivers State Polytechnic", 2, 32 },
                    { 177, "", "College of Agriculture, Jalingo", 2, 34 },
                    { 178, "", "Federal Polytechnic, Damaturu", 2, 35 },
                    { 179, "", "Mai Idris Alooma Polytechnic", 2, 35 },
                    { 162, "", "Federal College of Animal Health and Production Technology, Ibadan", 2, 30 },
                    { 161, "", "Federal College of Animal Health & Production Technology", 2, 30 },
                    { 160, "", "Southern Nigeria Institute of Innovative Technology (SNIITPOLY)", 2, 29 },
                    { 159, "", "Interlink Polytechnic", 2, 29 },
                    { 141, "", "Federal College of Fresh Water Fisheries Technology", 2, 26 },
                    { 142, "", "Federal College of Wildlife Management", 2, 26 },
                    { 143, "", "Federal Polytechnic, Bida", 2, 26 },
                    { 144, "", "Niger State College of Agriculture", 2, 26 },
                    { 145, "", "Niger State Polytechnic", 2, 26 },
                    { 146, "", "Abraham Adesanya Polytechnic", 2, 27 },
                    { 147, "", "Allover Central Polytechnic", 2, 27 },
                    { 148, "", "Federal Polytechnic, Ilaro", 2, 27 },
                    { 98, "", "Federal School of Dental Technology & Therapy", 2, 14 },
                    { 149, "", "Gateway Polytechnic Saapade", 2, 27 },
                    { 151, "", "Moshood Abiola Polytechnic", 2, 27 },
                    { 152, "", "Ogun State College of Health Technology", 2, 27 },
                    { 153, "", "Rufus Giwa Polytechnic", 2, 28 },
                    { 154, "", "Federal Polytechnic, Ede", 2, 29 },
                    { 155, "", "Osun State College of Technology", 2, 29 },
                    { 156, "", "Osun State Polytechnic", 2, 29 },
                    { 157, "", "Igbajo Polytechnic, Igbajo", 2, 29 },
                    { 158, "", "Polytechnic Ile-Ife", 2, 29 },
                    { 150, "", "Marvic Polytechnic", 2, 27 },
                    { 97, "", "Federal Polytechnic, Ado-Ekiti", 2, 13 },
                    { 12, "MCIU", "Michael and Cecilia Ibru University", 3, 10 },
                    { 95, "", "Kings Polytechnic", 2, 12 },
                    { 34, "CU", "City University", 3, 24 },
                    { 35, "NOUN", "National Open University of Nigeria", 3, 24 },
                    { 36, "LASU", "Lagos State University", 3, 24 },
                    { 37, "UNILAG", "University of Lagos", 3, 24 },
                    { 38, "BU", "ECWA Bingham University", 3, 25 },
                    { 39, "FUNAAB", "Federal University of Agriculture, Abeokuta", 3, 27 },
                    { 40, "BU", "Babcock University", 3, 27 },
                    { 41, "BUT", "Bells University of Technology", 3, 27 },
                    { 42, "CU", "Covenant University", 3, 27 },
                    { 43, "CU", "Crawford University", 3, 27 },
                    { 44, "CU", "Crescent University", 3, 27 },
                    { 45, "OOU", "Olabisi Onabanjo University", 3, 27 },
                    { 46, "AAUA", "Adekunle Ajasin University", 3, 28 },
                    { 47, "AAUA", "Adekunle Ajasin University", 3, 28 },
                    { 48, "AC", "Achievers University", 3, 28 },
                    { 49, "", "Elizade University", 3, 28 },
                    { 50, "FUTA", "Federal University of Technology Akure", 3, 28 },
                    { 33, "CUl", "Caleb University", 3, 24 },
                    { 32, "CU", "CETEP City University", 3, 24 },
                    { 31, "LU", "Landmark University", 3, 23 },
                    { 30, "", "University of Ilorin", 3, 23 },
                    { 181, "", "Federal Polytechnic, Namoda", 2, 36 },
                    { 13, "EBSU", "Ebonyi State University", 3, 11 },
                    { 14, "EUA", "Evangel University, Akaeze", 3, 11 },
                    { 15, "AAU", "Ambrose Alli University", 3, 12 },
                    { 16, "BIU", "Benson Idahosa University", 3, 12 },
                    { 17, "IUO", "Igbinedion University", 3, 12 },
                    { 18, "UNIBEN", "University of Benin", 3, 12 },
                    { 19, "ABUAD", "Afe Babalola University", 3, 13 },
                    { 51, "JABU", "Joseph Ayo Babalola University", 3, 29 },
                    { 20, "CU", "Crawford University", 3, 13 },
                    { 22, "GOU", "Godfrey Okoye University", 3, 14 },
                    { 23, "UNN", "University of Nigeria, Nsukka", 3, 14 },
                    { 24, "ABU", "Ahmadu Bello University", 3, 18 },
                    { 25, "CUT", "City University of Technology", 3, 18 },
                    { 26, "BUK", "Bayero University", 3, 19 },
                    { 27, "FUDM", "Federal University, Dutsin-Ma", 3, 20 },
                    { 28, "UMYU", "Umaru Musa Yar'adua University Katsina", 3, 20 },
                    { 29, "AHU", "Al-Hikmah University", 3, 23 },
                    { 21, "CU", "Caritas University", 3, 14 },
                    { 52, "RUN", "Redeemer's University Nigeria", 3, 29 },
                    { 53, "BU", "Bowen University", 3, 29 },
                    { 54, "FUO", "Fountain University, Osogbo", 3, 29 },
                    { 77, "", "The UA College of Science and Technology , Isuofia", 2, 4 },
                    { 78, "", "Abubakar Tafari Ali Polytechnic", 2, 5 },
                    { 79, "", "Federal Polytechnic, Bauchi", 2, 5 },
                    { 80, "", "Bayelsa State College of Arts and Science", 2, 6 },
                    { 81, "", "Federal Polytechnic Ekowe Bayelsa State", 2, 6 },
                    { 82, "", "Benue State Polytechnic", 2, 7 },
                    { 83, "", "Akperan Orshi College of Agriculture", 2, 7 },
                    { 84, "", "Borno College of Agriculture", 2, 8 },
                    { 76, "", "Federal Polytechnic, Oko", 2, 4 },
                    { 85, "", "Ramat Polytechnic", 2, 8 },
                    { 87, "", "The Polytechnic, Calabar", 2, 9 },
                    { 88, "", "Divine Polytechnic, Mkpani", 2, 9 },
                    { 89, "", "Delta State College of Agriculture", 2, 9 },
                    { 90, "", "Delta State Polytechnic�(three institutions)", 2, 10 },
                    { 91, "", "Petroleum Training Institute", 2, 10 },
                    { 92, "", "Akanu Ibiam Federal Polytechnic", 2, 11 },
                    { 93, "", "Federal College of Agriculture, Ishiagu", 2, 11 },
                    { 94, "", "Auchi Polytechnic", 2, 12 },
                    { 86, "", "Ibrahim Babangida College of Agriculture", 2, 9 },
                    { 96, "", "Shaka Polytechnic", 2, 12 },
                    { 75, "", "Ekwenugo Okeke Polytechnic", 2, 4 },
                    { 73, "", "Heritage Polytechnic", 2, 3 },
                    { 55, "OUI", "Oduduwa University", 3, 29 },
                    { 56, "OAU", "Obafemi Awolowo University", 3, 29 },
                    { 57, "ACU", "Ajayi Crowther University", 3, 30 },
                    { 58, "KU", "Koladaisi University", 3, 30 },
                    { 59, "UI", "University of Ibadan", 3, 30 },
                    { 60, "", "Universoty of Jos", 3, 31 },
                    { 61, "UNIPORT", "University of Port Harcourt", 3, 32 },
                    { 62, "", "Taraba State University", 3, 34 },
                    { 74, "", "Maritime Academy of Nigeria", 2, 3 },
                    { 63, "YSU", "Bukar Abba Ibrahim University", 3, 35 },
                    { 65, "NTNU", "Nigerian Turkish Nile University", 3, 37 },
                    { 66, "FUNAI", "Federal University Ndufe Alike, Ikwo", 3, 11 },
                    { 67, "", "Dorben Polytechnic", 2, 37 },
                    { 68, "", "Adamawa State Polytechnic", 2, 2 },
                    { 69, "", "Federal Polytechnic, Mubi", 2, 2 },
                    { 70, "", "Akwa Ibom State Polytechnic", 2, 3 },
                    { 71, "", "Akwa-Ibom College of Agriculture", 2, 3 },
                    { 72, "", "Foundation College of Technology", 2, 3 },
                    { 64, "VUNA", "Veritas University (Catholic University of Nigeria) Abuja", 3, 37 },
                    { 182, "", "Abdul Gusau Polytechnic", 2, 36 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Animal Science" },
                    { 21, 4, "Banking & Finance" },
                    { 22, 4, "Business Management" },
                    { 23, 5, "Arts Education" },
                    { 24, 5, "Science Education" },
                    { 25, 5, "Adult Education" },
                    { 26, 5, "Education Foundation" },
                    { 27, 5, "Health & Physical Education" },
                    { 28, 5, "Library Sciences Education" },
                    { 29, 5, "Social Science Education" },
                    { 30, 5, "Computer Education" },
                    { 31, 5, "Home Economics" },
                    { 32, 5, "Vocational Teacher Education" },
                    { 57, 6, "Philosophy" },
                    { 20, 4, "Business Administration" },
                    { 58, 6, "Public Administration" },
                    { 60, 6, "Economics" },
                    { 61, 6, "Geography" },
                    { 62, 6, "Sociology & Anthropology" },
                    { 63, 6, "Religious and Cultural Studies" },
                    { 64, 6, "Social Work" },
                    { 33, 7, "Civil Engineering" },
                    { 34, 7, "Electronic Engineering" },
                    { 35, 7, "Electrical Engineering" },
                    { 36, 7, "Mechanical Engineering" },
                    { 37, 7, "Agric. & Bioresources Engineering" },
                    { 38, 7, "Materials & Metallurgical Engineering" },
                    { 14, 11, "Microbiology" },
                    { 15, 11, "Biochemistry" },
                    { 59, 6, "Psychology" },
                    { 19, 4, "Marketing" },
                    { 18, 4, "Accountancy" },
                    { 39, 3, "Anaesthesia" },
                    { 2, 1, "Soil Science" },
                    { 3, 1, "Agric. Economics" },
                    { 4, 1, "Agric. Extension" },
                    { 5, 2, "Mass Communication" },
                    { 6, 2, "Archaeology & Tourism" },
                    { 7, 2, "History & International Studies" },
                    { 8, 2, "Fine & Applied Arts" },
                    { 9, 2, "Performing Arts" },
                    { 10, 2, "Music" },
                    { 11, 2, "English & Literary Studies" },
                    { 12, 2, "Foreign Languages" },
                    { 13, 2, "Linguistics & Nigerian Languages" },
                    { 56, 3, "Surgery" },
                    { 55, 3, "Radiation Medicine" },
                    { 54, 3, "Physiological Medicine" },
                    { 53, 3, "Pharmacology & Therapeutics" },
                    { 52, 3, "Paediatric Surgery" },
                    { 51, 3, "Paediatrics" },
                    { 50, 3, "Otolaringology" },
                    { 49, 3, "Ophthalmology" },
                    { 48, 3, "Obstetrics & Gaenecology" },
                    { 47, 3, "Morbid Anatomy" },
                    { 46, 3, "Medical Microbiology" },
                    { 45, 3, "Medical Biochemistry" },
                    { 44, 3, "Haematology & Immunology" },
                    { 43, 3, "Dermatology" },
                    { 42, 3, "Community Medicine" },
                    { 41, 3, "Chemical Pathology" },
                    { 40, 3, "Anatomy" },
                    { 16, 11, "Plant Sciences" },
                    { 17, 11, "Zoology" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schools_StateId",
                table: "Schools",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Faculties_FacultyId",
                table: "Courses",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Faculties_Schools_SchoolId",
                table: "Faculties",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_States_StateId",
                table: "Schools",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Faculties_FacultyId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Schools_SchoolId",
                table: "Faculties");

            migrationBuilder.DropForeignKey(
                name: "FK_Schools_States_StateId",
                table: "Schools");

            migrationBuilder.DropIndex(
                name: "IX_Schools_StateId",
                table: "Schools");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Governors",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "Schools");

            migrationBuilder.RenameColumn(
                name: "Abbreviation",
                table: "Schools",
                newName: "Acronym");

            migrationBuilder.RenameColumn(
                name: "StartsTenure",
                table: "Governors",
                newName: "ToYear");

            migrationBuilder.RenameColumn(
                name: "EndsTenure",
                table: "Governors",
                newName: "FromYear");

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "Faculties",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FacultyId",
                table: "Courses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Acronym", "Name" },
                values: new object[] { "OAU", "Obafemi Awolowo University" });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Acronym", "Name" },
                values: new object[] { "Unilag", "University of Lagos" });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Acronym", "Name" },
                values: new object[] { "UI", "University of Ibadan" });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Acronym", "Name" },
                values: new object[] { "AAU", "Ambrose Alli University" });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Acronym", "Name" },
                values: new object[] { "OOU", "Olabisi Onabanjo University" });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Acronym", "Name", "SchoolCategoryId" },
                values: new object[] { "Laspotech", "Lagos State Polytechnic", 2 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Acronym", "Name", "SchoolCategoryId" },
                values: new object[] { "Yabatech", "Federal Polytechnic", 2 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Acronym", "Name", "SchoolCategoryId" },
                values: new object[] { "IbadanPoly", "The Polytechnic Ibadan", 2 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Acronym", "Name", "SchoolCategoryId" },
                values: new object[] { "Mapoly", "Moshood Abiola Polytechnic", 2 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Acronym", "Name", "SchoolCategoryId" },
                values: new object[] { "PolyCal", "The Polytechnic, Calabar", 2 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Acronym", "Name", "SchoolCategoryId" },
                values: new object[] { "AOC", "Adeniran Ogunsanya College", 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Faculties_FacultyId",
                table: "Courses",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Faculties_Schools_SchoolId",
                table: "Faculties",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
