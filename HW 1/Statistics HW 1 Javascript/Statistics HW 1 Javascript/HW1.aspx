<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HW1.aspx.cs" Inherits="Statistics_HW_1_Javascript.HW1" %>

<!DOCTYPE html>  
<html lang = "en">  
<head>  
<meta charset = "UTF-8">  
<meta name = "viewport" content = "width=device-width, initial-scale=1.0">  
<title> Homework 1 </title>  
</head>  
<body>  
    <h3> HW 1 JavaScript: Linea, Punto, Cerchio, Rettangolo  </h3>  
    <canvas id = "canvas_data" height = "400" width = "600" style = "background-color:lightgrey;">  
    </canvas>  
    <script>  
        function draw_line() {  
            const canvas_var = document.querySelector('#canvas_data');  
            if (!canvas_var.getContext) {  
                return;  
            }  
            const ct_var = canvas_var.getContext('2d');   
            ct_var.strokeStyle = 'black';  
            ct_var.lineWidth = 5;  
 
            ct_var.beginPath();  
 
            ct_var.moveTo(300, 300);   
            ct_var.lineTo(500, 300);  
            ct_var.stroke();  
        }  

        draw_line();  

        function draw_rectangles() {
            const canvas = document.querySelector('#canvas_data');

            if (!canvas.getContext) {
                return;
            }

            const ctx = canvas.getContext('2d');

            ctx.fillStyle = 'darkblue';
            ctx.fillRect(120, 100, 150, 100);

            ctx.fillStyle = 'white';
            ctx.fillRect(200, 150, -150, -100);

            ctx.fillStyle = 'darkred';
            ctx.fillRect(220, 150, 150, 100);
        }

        draw_rectangles();

        function draw_circle() {
            const canvas = document.querySelector('#canvas_data');
            const context = canvas.getContext('2d');

            const centerX_circle = canvas.width - 125;
            const centerY_circle = canvas.height - 250;
            const radius_circle = 50;

            context.beginPath();

            context.arc(centerX_circle, centerY_circle, radius_circle, 0, 2 * Math.PI, false);
            context.fillStyle = 'yellow';
            context.fill();

            context.lineWidth = 1;
            context.strokeStyle = '#003300';
            context.stroke();
        }

        draw_circle();
        
        function draw_dot() {
            const canvas = document.querySelector('#canvas_data');
            const context = canvas.getContext('2d');

            const centerX_dot = canvas.width - 125;
            const centerY_dot = canvas.height - 150;
            const radius_dot = 3;

            context.beginPath();

            context.arc(centerX_dot, centerY_dot, radius_dot, 0, 2 * Math.PI, false);
            context.fillStyle = 'black';
            context.fill();

            context.lineWidth = 1;
            context.strokeStyle = '#003300';
            context.stroke();
        }

        draw_dot();
        
    </script>  
</body>  
</html> 