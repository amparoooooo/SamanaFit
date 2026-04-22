SamanáFit Pro


SamanáFit Pro es un sistema inteligente generador de rutinas de entrenamiento personalizadas, 
diseñado para usuarios que desean mejorar su condición física según su objetivo.


SamanaFitPro/
│
├── SamanaFit.Data/              # Biblioteca de clases para acceso a datos
│   ├── Entities/
│   │   ├── Usuario.cs
│   │   ├── Objetivo.cs
│   │   ├── Nivel.cs
│   │   ├── Ejercicio.cs
│   │   └── Rutina.cs
│   │
│   └── SamanaFitContext.cs
│
├── SamanaFit.UI/                # Proyecto WinForms
│   ├── Services/
│   │   ├── IRutinaService.cs
│   │   └── RutinaService.cs
│   │
│   ├── Forms/
│   │   ├── MainForm.cs
│   │   ├── UsuariosForm.cs
│   │   ├── ObjetivosForm.cs
│   │   ├── NivelesForm.cs
│   │   ├── EjerciciosForm.cs
│   │   ├── RutinasForm.cs
│   │   └── ReportesForm.cs
│   │
│   └── Program.cs
│
└── SamanaFit.Tests/             # Pruebas unitarias
    └── RutinaServiceTests.cs
