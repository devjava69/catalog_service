CREATE TABLE IF NOT EXISTS Coupon (
		ID SERIAL PRIMARY KEY			NOT NULL,
		ProductName		VARCHAR(24) NOT NULL,
		Description		TEXT,
		Amount			INT
	);

INSERT INTO Coupon (ProductName, Description, Amount) VALUES ('pendule', 'pendule discount', 150);
INSERT INTO Coupon (ProductName, Description, Amount) VALUES ('"horloge en or', '"horloge en or discount', 100);



https://localhost:5005/connect/authorize?

client_id=movies_mvc_client

&redirect_uri=https%3A%2F%2Flocalhost%3A5002%2Fsignin-oidc&

response_type=code&

scope=openid%20profile&

code_challenge=2HknPGPUbUAEOfn1HYyBAJyAygf-SItQFrD0AtrYnw0&

code_challenge_method=S256&

response_mode=form_post&

nonce=638415445276371703.MTkyOGMxZmYtNTM4My00YTdkLTkzZjEtMGE1ZGI5NTY4YWViNzM0ODdlZDgtYjZjNi00YzRhLWE3OTItMzVkNmIwMzNkMTFj&
state=CfDJ8NBL-iD04PhDt91_nlc0mp0wHZrIs9N4_t8u5xhkeY00JTIipcJfoOSes6KGDcoVNwm474aPMSbajkHyvZHQgYsYzU9H7bMzVB0QsIjZdoqDYdgwOdcoeZIDWpnEkfFXweqsvqD-9jJYWqPHuAX9jvHqzRRHig6JQuE5zWdXurZ8SqFtb9cLyP6YRSU5WvIcC8CvvvJNcAzb8BEAQ9GBoi
IChCsdIPxuxGkXuPCFLenhjchYJKt5-u_pXlzeVDUBVegrfkZArhH4v4H2lGF9XK2lENpUbY6cqs47utUMu1xVQpagCi_xBMxqh6Zg0YHryHxyDub5pofj9Ox8tRMc7o_m8Tk44asErJQz5P7UMxojFNHLlh9ul7NvuzBpx7qJfA&

x-client-SKU=ID_NETSTANDARD2_0&

x-client-ver=6.7.1.0
