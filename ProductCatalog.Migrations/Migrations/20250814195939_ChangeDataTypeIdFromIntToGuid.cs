using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductCatalog.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDataTypeIdFromIntToGuid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 1. Creating new tables with Guid PK/FK
            // User table
            migrationBuilder.CreateTable(
                name: "user_new",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    username = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    passwordHash = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    role = table.Column<string>(type: "TEXT", nullable: true, defaultValue: "Basic Role")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_new", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_user_new_username",
                table: "user_new",
                column: "username",
                unique: true);

            // Company table
            migrationBuilder.CreateTable(
                name: "company_new",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    dateCreation = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    country = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company_new", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_company_new_name",
                table: "company_new",
                column: "name",
                unique: true);

            // Category table
            migrationBuilder.CreateTable(
                name: "category_new",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category_new", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_category_new_name",
                table: "category_new",
                column: "name",
                unique: true);

            // Type product table
            migrationBuilder.CreateTable(
                name: "type_new",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    categoryId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_type_new", x => x.id);
                    table.ForeignKey(
                        name: "FK_type_new_category_new_categoryId",
                        column: x => x.categoryId,
                        principalTable: "category_new",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_type_new_name",
                table: "type_new",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_type_new_categoryId",
                table: "type_new",
                column: "categoryId");

            // Product table
            migrationBuilder.CreateTable(
                name: "product_new",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    typeId = table.Column<Guid>(type: "TEXT", nullable: false),
                    price = table.Column<double>(type: "NUMERIC", nullable: false),
                    destination = table.Column<string>(type: "TEXT", nullable: true),
                    companyId = table.Column<Guid>(type: "TEXT", nullable: false),
                    categoryId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_new", x => x.id);
                    table.ForeignKey(
                        name: "FK_product_new_category_new_categoryId",
                        column: x => x.categoryId,
                        principalTable: "category_new",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_product_new_company_new_companyId",
                        column: x => x.companyId,
                        principalTable: "company_new",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_product_new_type_new_typeId",
                        column: x => x.typeId,
                        principalTable: "type_new",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_product_new_categoryId",
                table: "product_new",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_product_new_companyId",
                table: "product_new",
                column: "companyId");

            migrationBuilder.CreateIndex(
                name: "IX_product_new_name",
                table: "product_new",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_product_new_typeId",
                table: "product_new",
                column: "typeId");

            // 2. Create temporary mapper tables with standard GUID generation via randomblob
            migrationBuilder.Sql(@"
                CREATE TEMP TABLE category_map (old_id INTEGER, new_id TEXT);
                INSERT INTO category_map(old_id, new_id)
                SELECT id,
                       (
                            substr(hex(randomblob(4)), 1, 8) || '-' ||
                            substr(hex(randomblob(2)), 1, 4) || '-' ||
                            '4' || substr(hex(randomblob(2)), 2, 3) || '-' ||
                            substr('89AB', abs(random()) % 4 + 1, 1) || 
                            substr(hex(randomblob(2)), 2, 3) || '-' ||
                            substr(hex(randomblob(6)), 1, 12)
                       ) as guid
                FROM category;

                CREATE TEMP TABLE type_map (old_id INTEGER, new_id TEXT);
                INSERT INTO type_map(old_id, new_id)
                SELECT id,
                       (
                            substr(hex(randomblob(4)), 1, 8) || '-' ||
                            substr(hex(randomblob(2)), 1, 4) || '-' ||
                            '4' || substr(hex(randomblob(2)), 2, 3) || '-' ||
                            substr('89AB', abs(random()) % 4 + 1, 1) || 
                            substr(hex(randomblob(2)), 2, 3) || '-' ||
                            substr(hex(randomblob(6)), 1, 12)
                       ) as guid
                FROM type;

                CREATE TEMP TABLE company_map (old_id INTEGER, new_id TEXT);
                INSERT INTO company_map(old_id, new_id)
                SELECT id,
                       (
                            substr(hex(randomblob(4)), 1, 8) || '-' ||
                            substr(hex(randomblob(2)), 1, 4) || '-' ||
                            '4' || substr(hex(randomblob(2)), 2, 3) || '-' ||
                            substr('89AB', abs(random()) % 4 + 1, 1) || 
                            substr(hex(randomblob(2)), 2, 3) || '-' ||
                            substr(hex(randomblob(6)), 1, 12)
                       ) as guid
                FROM company;

                CREATE TEMP TABLE user_map (old_id INTEGER, new_id TEXT);
                INSERT INTO user_map(old_id, new_id)
                SELECT id,
                       (
                            substr(hex(randomblob(4)), 1, 8) || '-' ||
                            substr(hex(randomblob(2)), 1, 4) || '-' ||
                            '4' || substr(hex(randomblob(2)), 2, 3) || '-' ||
                            substr('89AB', abs(random()) % 4 + 1, 1) || 
                            substr(hex(randomblob(2)), 2, 3) || '-' ||
                            substr(hex(randomblob(6)), 1, 12)
                       ) as guid
                FROM user;
            ");

            // 3. Transferring data while maintaining connections
            migrationBuilder.Sql(@"
                INSERT INTO category_new (id, name)
                SELECT m.new_id, c.name
                FROM category c
                JOIN category_map m ON c.id = m.old_id;

                INSERT INTO type_new (id, name, categoryId)
                SELECT tm.new_id, t.name, cm.new_id
                FROM type t
                JOIN type_map tm ON t.id = tm.old_id
                JOIN category_map cm ON t.categoryId = cm.old_id;

                INSERT INTO company_new (id, name, dateCreation, country)
                SELECT m.new_id, c.name, c.dateCreation, c.country
                FROM company c
                JOIN company_map m ON c.id = m.old_id;

                INSERT INTO user_new (id, username, passwordHash, role)
                SELECT m.new_id, u.username, u.passwordHash, u.role
                FROM user u
                JOIN user_map m ON u.id = m.old_id;

                INSERT INTO product_new (id, name, typeId, price, destination, companyId, categoryId)
                SELECT (
                            substr(hex(randomblob(4)), 1, 8) || '-' ||
                            substr(hex(randomblob(2)), 1, 4) || '-' ||
                            '4' || substr(hex(randomblob(2)), 2, 3) || '-' ||
                            substr('89AB', abs(random()) % 4 + 1, 1) || 
                            substr(hex(randomblob(2)), 2, 3) || '-' ||
                            substr(hex(randomblob(6)), 1, 12)
                       ) as guid,
                       p.name,
                       tm.new_id,
                       p.price,
                       p.destination,
                       cm.new_id,
                       catm.new_id
                FROM product p
                JOIN type_map tm ON p.typeId = tm.old_id
                JOIN company_map cm ON p.companyId = cm.old_id
                JOIN category_map catm ON p.categoryId = catm.old_id;
            ");

            // 4. Delete old tables
            migrationBuilder.DropTable(name: "product");
            migrationBuilder.DropTable(name: "type");
            migrationBuilder.DropTable(name: "category");
            migrationBuilder.DropTable(name: "company");
            migrationBuilder.DropTable(name: "user");

            // 5. Renaming new tables
            migrationBuilder.RenameTable(name: "category_new", newName: "category");
            migrationBuilder.RenameTable(name: "type_new", newName: "type");
            migrationBuilder.RenameTable(name: "product_new", newName: "product");
            migrationBuilder.RenameTable(name: "company_new", newName: "company");
            migrationBuilder.RenameTable(name: "user_new", newName: "user");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "product");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "company");

            migrationBuilder.DropTable(
                name: "type");

            migrationBuilder.DropTable(
                name: "category");
        }
    }
}
