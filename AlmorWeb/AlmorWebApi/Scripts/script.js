var config = {
    type: "bar",
    data:{
        datasets:[{
            data:[
                70,
                1,
                1,
                2,
                2,
                3,
                10
            ],
            backgroundColor:[
                'rgb(0, 247, 132)',
                'rgb(247, 132, 0)',
                'rgb(252, 239, 53)',
                'rgb(162, 53, 252)',
                'rgb(53, 56, 252)',
                'rgb(252, 53, 53)',
                '#35D0FC'
            ],
            label: "Percentual das atividades"
           
        }],
        labels:[
            "OK",
            "Esquerda",
            "Direita",
            "Frente",
            "Trás",
            "Estresse",
            "Levantado"]
        
    },
    options: {
            responsive: true,
            
            maintainAspectRatio: false,
            layout: {
                padding: {
                    left: 5,
                    right: 0,
                    top: 10,
                    bottom: 10
                }
            },
            scales:{
                yAxes:[{
                    ticks:{
                        suggestedMax: 100
                    }
                }]
            }
        }
        
};
var config2 = {
    type: "pie",
    data:{
        datasets:[{
            data:[
                70,
                5,
                25
            ],
            backgroundColor:[
                'rgb(0, 247, 132)',
                'rgb(252, 53, 53)',
                '#35D0FC'
            ],
            label: "Percentual das atividades"
           
        }],
        labels:[
            "OK",
            "Errado",
            "Levantado"]
        
    },
    options: {
            responsive: true,
            
            maintainAspectRatio: false,
            layout: {
                padding: {
                    left: 5,
                    right: 0,
                    top: 10,
                    bottom: 10
                }
            },
            
        }
        
};

/*window.onload = function(){
    window.myPie = new Chart(ctx,config);
    
};*/

var charts = new Array();
charts["1-g"] ;

$(document).ready(function () {

    $(".user-btn").click( function () {
        $(".menu").toggleClass("hilighted");
        $(".user-btn").toggleClass("hilighted");
    })
    $(".tab").click(function () {
        
        $(".tab").removeClass("tab-hilighted");
        $(this).addClass("tab-hilighted");
        $(".tab-content").removeClass("tab-content-hilighted");
        $("#" + $(this).attr("id").replace("tab","content")).addClass("tab-content-hilighted");
        
    })
    $(".acc").click(function () {
        
       // $(".acc").removeClass("acc-hilighted");
        $(this).toggleClass("acc-hilighted");
        //$(".acc-content").removeClass("acc-content-hilighted");
        $("#" + $(this).attr("id").replace("acc","content"))
        .toggleClass("acc-content-hilighted");

        $("#" + $(this).attr("id").replace("acc","left"))
        .html('<canvas id="'+ $(this).attr("id").replace("acc","pie") 
        +'"></canvas>');

        $("#" + $(this).attr("id").replace("acc","right"))
        .html('<canvas id="'+ $(this).attr("id").replace("acc","bar") 
        +'"></canvas>');

        $("#" + $(this).attr("id").replace("acc","left")).removeClass("minimized");
        $("#" + $(this).attr("id").replace("acc","menu-icon")).removeClass("left");
        
    })
    $(".graph-menu").click(function(){
       
        $("#" + $(this).attr("id").replace("menu","left")).toggleClass("minimized");
        $("#" + $(this).attr("id").replace("menu","menu-icon")).toggleClass("left");
        ;
        //$("#" + $(this).attr("id").replace("menu","right")).toggleClass("minimized");
    });
     
    $(".acc-content")
        .on("transitionend webkitTransitionEnd oTransitionEnd MSTransitionEnd",
       
        function(e){
        if(e.target.id.includes("content"))
        {
            var myPie = new Chart($("#"+ e.target.id.replace("content","pie")),config2);
           var  myPie2 = new Chart($("#"+ e.target.id.replace("content","bar")),config);
        }
        if(e.target.id.includes('left'))
        {
                $("#"+ e.target.id).html('<canvas id="'+ e.target.id.replace("left","pie") 
                +'"></canvas>');
                var myPie = new Chart($("#"+ e.target.id.replace("left","pie")),config2);
                $("#"+ e.target.id.replace("left","right")).html('<canvas id="'+ e.target.id.replace("left","bar") 
                +'"></canvas>');
                var myPie2 = new Chart($("#"+ e.target.id.replace("left","bar")),config);
        }    
           
    });
    
})

