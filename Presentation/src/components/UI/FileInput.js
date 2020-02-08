import React from 'react';

const FileInput = props => {
    return (
        <form>
            <input type='file' name='file' className='btn btn-secondary' onChange={props.onChange} />
            {props.loading ? (
                <button className='btn btn-primary pull-right' type='button' disabled>
                    <span className='spinner-border spinner-border-sm' role='status' aria-hidden='true'></span>
                    &nbsp;&nbsp;Cargando...
                </button>
            ) : (
                <button type='submit' className='btn btn-primary' onClick={props.onUpload}>
                    Subir archivo CSV
                </button>
            )}
        </form>
    );
};

export default FileInput;